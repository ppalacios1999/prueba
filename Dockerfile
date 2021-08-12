FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build-env
WORKDIR /app

RUN apt-get update && \
    apt-get install -y wget && \
    apt-get install -y gnupg2 && \
    wget -qO- https://deb.nodesource.com/setup_10.x | bash - && \
    apt-get install -y build-essential nodejs

RUN apt-get update -qq && apt-get -y install libgdiplus libc6-dev
#RUN apt-get install libjpeg62
#RUN apt-get install xvfb libfontconfig wkhtmltopdf

EXPOSE 80 443

COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim
WORKDIR /app
COPY --from=build-env /app/out .
RUN chmod 755 /app/Tools/Linux/wkhtmltopdf

ENV TZ=America/Bogota
RUN ln -snf /usr/share/zoneinfo/$TZ /etc/localtime && echo $TZ > /etc/timezone

ENTRYPOINT ["dotnet", "Backend.InhumacionCremacion.API.dll"]