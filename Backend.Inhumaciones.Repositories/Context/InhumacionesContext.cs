using Backend.Inhumaciones.Entities.Models.Inhumaciones;
using Microsoft.EntityFrameworkCore;

namespace Backend.Inhumaciones.Repositories.Context
{
    public partial class InhumacionesContext : DbContext
    {
        public InhumacionesContext(DbContextOptions<InhumacionesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AprobacionLicencia> AprobacionLicencia { get; set; }
        public virtual DbSet<Archivos> Archivos { get; set; }
        public virtual DbSet<EstadoTramiteLicenciaexh> EstadoTramiteLicenciaexh { get; set; }
        public virtual DbSet<LicenciaExhuma> LicenciaExhuma { get; set; }
        public virtual DbSet<NotificacionExh> NotificacionExh { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<PrBarrio> PrBarrio { get; set; }
        public virtual DbSet<PrCausalesNegacion> PrCausalesNegacion { get; set; }
        public virtual DbSet<PrDepartamento> PrDepartamento { get; set; }
        public virtual DbSet<PrEquiposRadiacion> PrEquiposRadiacion { get; set; }
        public virtual DbSet<PrEstadoTramite> PrEstadoTramite { get; set; }
        public virtual DbSet<PrEstadocivil> PrEstadocivil { get; set; }
        public virtual DbSet<PrEtnia> PrEtnia { get; set; }
        public virtual DbSet<PrFaqtips> PrFaqtips { get; set; }
        public virtual DbSet<PrInstitucion> PrInstitucion { get; set; }
        public virtual DbSet<PrLocalidad> PrLocalidad { get; set; }
        public virtual DbSet<PrMunicipio> PrMunicipio { get; set; }
        public virtual DbSet<PrNivelacademico> PrNivelacademico { get; set; }
        public virtual DbSet<PrNiveleducativo> PrNiveleducativo { get; set; }
        public virtual DbSet<PrOpcion> PrOpcion { get; set; }
        public virtual DbSet<PrPais> PrPais { get; set; }
        public virtual DbSet<PrPerfil> PrPerfil { get; set; }
        public virtual DbSet<PrPregunta> PrPregunta { get; set; }
        public virtual DbSet<PrPrestadorservicio> PrPrestadorservicio { get; set; }
        public virtual DbSet<PrPrograma> PrPrograma { get; set; }
        public virtual DbSet<PrProgramaEquivalente> PrProgramaEquivalente { get; set; }
        public virtual DbSet<PrProgramasUniv> PrProgramasUniv { get; set; }
        public virtual DbSet<PrPuntoatencion> PrPuntoatencion { get; set; }
        public virtual DbSet<PrRayosxEstadoTramite> PrRayosxEstadoTramite { get; set; }
        public virtual DbSet<PrRayosxItemsInfra> PrRayosxItemsInfra { get; set; }
        public virtual DbSet<PrRazonAsistencia> PrRazonAsistencia { get; set; }
        public virtual DbSet<PrRazonSeguimiento> PrRazonSeguimiento { get; set; }
        public virtual DbSet<PrResponsablecuidado> PrResponsablecuidado { get; set; }
        public virtual DbSet<PrSexo> PrSexo { get; set; }
        public virtual DbSet<PrSubred> PrSubred { get; set; }
        public virtual DbSet<PrTipoSeguimiento> PrTipoSeguimiento { get; set; }
        public virtual DbSet<PrTipoVisualizacion> PrTipoVisualizacion { get; set; }
        public virtual DbSet<PrTipoidentificacion> PrTipoidentificacion { get; set; }
        public virtual DbSet<PrUpz> PrUpz { get; set; }
        public virtual DbSet<RayosxCategoria> RayosxCategoria { get; set; }
        public virtual DbSet<RayosxDireccion> RayosxDireccion { get; set; }
        public virtual DbSet<RayosxDirector> RayosxDirector { get; set; }
        public virtual DbSet<RayosxDocumentos> RayosxDocumentos { get; set; }
        public virtual DbSet<RayosxEncargado> RayosxEncargado { get; set; }
        public virtual DbSet<RayosxEquipoInfra> RayosxEquipoInfra { get; set; }
        public virtual DbSet<RayosxEquipos> RayosxEquipos { get; set; }
        public virtual DbSet<RayosxObjprueba> RayosxObjprueba { get; set; }
        public virtual DbSet<RayosxResoluciones> RayosxResoluciones { get; set; }
        public virtual DbSet<RayosxTipoTramite> RayosxTipoTramite { get; set; }
        public virtual DbSet<RayosxToe> RayosxToe { get; set; }
        public virtual DbSet<RayosxTramite> RayosxTramite { get; set; }
        public virtual DbSet<RayosxTramiteFlujo> RayosxTramiteFlujo { get; set; }
        public virtual DbSet<RayosxValidacion> RayosxValidacion { get; set; }
        public virtual DbSet<RegistroRayosx> RegistroRayosx { get; set; }
        public virtual DbSet<RegistroTitulo> RegistroTitulo { get; set; }
        public virtual DbSet<ResolucionesTitulo> ResolucionesTitulo { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<SeguimientoTramite> SeguimientoTramite { get; set; }
        public virtual DbSet<SstRegistro> SstRegistro { get; set; }
        public virtual DbSet<SstTramite> SstTramite { get; set; }
        public virtual DbSet<SstTramiteFlujo> SstTramiteFlujo { get; set; }
        public virtual DbSet<Subredes> Subredes { get; set; }
        public virtual DbSet<TodosLosTramites> TodosLosTramites { get; set; }
        public virtual DbSet<Tramites> Tramites { get; set; }
        public virtual DbSet<TsAuditoriapersona> TsAuditoriapersona { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<ValidacionTitulos> ValidacionTitulos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AprobacionLicencia>(entity =>
            {
                entity.HasKey(e => e.Idaprobacion)
                    .HasName("PRIMARY");

                entity.ToTable("aprobacion_licencia");

                entity.Property(e => e.Idaprobacion).HasColumnName("idaprobacion");

                entity.Property(e => e.Aprobado).HasColumnName("aprobado");

                entity.Property(e => e.Cementerio)
                    .HasColumnName("cementerio")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ControlDocum)
                    .HasColumnName("control_docum")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoApro)
                    .HasColumnName("estado_apro")
                    .HasColumnType("tinyint(1)")
                    .HasComment("Estado de aprobacion licencia");

                entity.Property(e => e.FechaAprob)
                    .HasColumnName("fecha_aprob")
                    .HasColumnType("date");

                entity.Property(e => e.FechaInhumacion)
                    .HasColumnName("fecha_inhumacion")
                    .HasColumnType("date");

                entity.Property(e => e.IdArchivo).HasColumnName("id_archivo");

                entity.Property(e => e.IdlicenciaExhumacion)
                    .HasColumnName("idlicencia_exhumacion")
                    .HasComment("foreign key tabla licencia exhumacion");

                entity.Property(e => e.NombreDifunto)
                    .HasColumnName("nombre_difunto")
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.NumCertdefunsion).HasColumnName("num_certdefunsion");

                entity.Property(e => e.NumDocdifunto).HasColumnName("num_docdifunto");

                entity.Property(e => e.NumLicenciaInhumacion).HasColumnName("num_licencia_inhumacion");

                entity.Property(e => e.NumeroLicExhu)
                    .HasColumnName("numero_lic_exhu")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NumeroVerificacion)
                    .HasColumnName("numero_verificacion")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones).HasColumnName("observaciones");

                entity.Property(e => e.Observacionesp).HasColumnName("observacionesp");

                entity.Property(e => e.Revisado).HasColumnName("revisado");
            });

            modelBuilder.Entity<Archivos>(entity =>
            {
                entity.HasKey(e => e.IdArchivo)
                    .HasName("PRIMARY");

                entity.ToTable("archivos");

                entity.Property(e => e.IdArchivo).HasColumnName("id_archivo");

                entity.Property(e => e.EsPublico)
                    .HasColumnName("es_publico")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ruta)
                    .HasColumnName("ruta")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Tags)
                    .HasColumnName("tags")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EstadoTramiteLicenciaexh>(entity =>
            {
                entity.HasKey(e => e.IdEstado)
                    .HasName("PRIMARY");

                entity.ToTable("estado_tramite_licenciaexh");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.DesEstado)
                    .HasColumnName("des_estado")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LicenciaExhuma>(entity =>
            {
                entity.HasKey(e => e.IdlicenciaExhumacion)
                    .HasName("PRIMARY");

                entity.ToTable("licencia_exhuma");

                entity.Property(e => e.IdlicenciaExhumacion).HasColumnName("idlicencia_exhumacion");

                entity.Property(e => e.DeclaracionJuramentada)
                    .HasColumnName("declaracion_juramentada")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaInhumacion)
                    .HasColumnName("fecha_inhumacion")
                    .HasColumnType("date");

                entity.Property(e => e.FechaSolicitud).HasColumnName("fecha_solicitud");

                entity.Property(e => e.IdPersona).HasColumnName("id_persona");

                entity.Property(e => e.IntervieneMedlegal).HasColumnName("interviene_medlegal");

                entity.Property(e => e.NumeroDocfallecido)
                    .HasColumnName("numero_docfallecido")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroLicencia)
                    .HasColumnName("numero_licencia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroRegdefuncion)
                    .HasColumnName("numero_regdefuncion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Parentesco)
                    .HasColumnName("parentesco")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PdfAutorizacionfiscal).HasColumnName("pdf_autorizacionfiscal");

                entity.Property(e => e.PdfCedulasolicitante).HasColumnName("pdf_cedulasolicitante");

                entity.Property(e => e.PdfCertificadoPer3).HasColumnName("pdf_certificado_per3");

                entity.Property(e => e.PdfCertificadoPer4).HasColumnName("pdf_certificado_per4");

                entity.Property(e => e.PdfCertificadocementerio).HasColumnName("pdf_certificadocementerio");

                entity.Property(e => e.PdfOrdenjudicial).HasColumnName("pdf_ordenjudicial");

                entity.Property(e => e.PdfOtro).HasColumnName("pdf_otro");
            });

            modelBuilder.Entity<NotificacionExh>(entity =>
            {
                entity.HasKey(e => e.Idnotificacion)
                    .HasName("PRIMARY");

                entity.ToTable("notificacion_exh");

                entity.Property(e => e.Idnotificacion).HasColumnName("idnotificacion");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.FechaRegistro).HasColumnName("fecha_registro");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.IdlicenciaExhumacion).HasColumnName("idlicencia_exhumacion");

                entity.Property(e => e.Observaciones).HasColumnName("observaciones");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona)
                    .HasName("PRIMARY");

                entity.ToTable("persona");

                entity.HasIndex(e => e.NumeIdentificacion)
                    .HasName("nume_identificacion")
                    .IsUnique();

                entity.Property(e => e.IdPersona).HasColumnName("id_persona");

                entity.Property(e => e.Barrio)
                    .HasColumnName("barrio")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadNacimiento).HasColumnName("ciudad_nacimiento");

                entity.Property(e => e.CiudadNacimientoOtro)
                    .HasColumnName("ciudad_nacimiento_otro")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadResi).HasColumnName("ciudad_resi");

                entity.Property(e => e.Cx).HasColumnName("cx");

                entity.Property(e => e.Cy).HasColumnName("cy");

                entity.Property(e => e.DepaResi).HasColumnName("depa_resi");

                entity.Property(e => e.Departamento).HasColumnName("departamento");

                entity.Property(e => e.DirCodificada)
                    .IsRequired()
                    .HasColumnName("dir_codificada")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DireResi).HasColumnName("dire_resi");

                entity.Property(e => e.Edad).HasColumnName("edad");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoCivil).HasColumnName("estado_civil");

                entity.Property(e => e.Estadogeo).HasColumnName("estadogeo");

                entity.Property(e => e.Etnia).HasColumnName("etnia");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("fecha_nacimiento")
                    .HasColumnType("date");

                entity.Property(e => e.Genero).HasColumnName("genero");

                entity.Property(e => e.Localidad).HasColumnName("localidad");

                entity.Property(e => e.Nacionalidad).HasColumnName("nacionalidad");

                entity.Property(e => e.NivelEducativo).HasColumnName("nivel_educativo");

                entity.Property(e => e.NombreRs)
                    .HasColumnName("nombre_rs")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NumeIdenRl).HasColumnName("nume_iden_rl");

                entity.Property(e => e.NumeIdentificacion).HasColumnName("nume_identificacion");

                entity.Property(e => e.Orientacion).HasColumnName("orientacion");

                entity.Property(e => e.PApellido)
                    .HasColumnName("p_apellido")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PNombre)
                    .IsRequired()
                    .HasColumnName("p_nombre")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SApellido)
                    .HasColumnName("s_apellido")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SNombre)
                    .IsRequired()
                    .HasColumnName("s_nombre")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo).HasColumnName("sexo");

                entity.Property(e => e.TelefonoCelular)
                    .IsRequired()
                    .HasColumnName("telefono_celular")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoFijo)
                    .IsRequired()
                    .HasColumnName("telefono_fijo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoIdenRl).HasColumnName("tipo_iden_rl");

                entity.Property(e => e.TipoIdentificacion).HasColumnName("tipo_identificacion");

                entity.Property(e => e.Upz).HasColumnName("upz");

                entity.Property(e => e.Zona).HasColumnName("zona");
            });

            modelBuilder.Entity<PrBarrio>(entity =>
            {
                entity.HasKey(e => e.IdBarrio)
                    .HasName("PRIMARY");

                entity.ToTable("pr_barrio");

                entity.Property(e => e.IdBarrio)
                    .HasColumnName("id_barrio")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.IdUpz).HasColumnName("id_upz");

                entity.Property(e => e.NombreBarrio)
                    .IsRequired()
                    .HasColumnName("nombre_barrio")
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrCausalesNegacion>(entity =>
            {
                entity.HasKey(e => e.IdCausal)
                    .HasName("PRIMARY");

                entity.ToTable("pr_causales_negacion");

                entity.Property(e => e.IdCausal).HasColumnName("id_causal");

                entity.Property(e => e.DescCausal)
                    .IsRequired()
                    .HasColumnName("desc_causal");
            });

            modelBuilder.Entity<PrDepartamento>(entity =>
            {
                entity.HasKey(e => e.IdDepartamento)
                    .HasName("PRIMARY");

                entity.ToTable("pr_departamento");

                entity.HasIndex(e => e.IdPais)
                    .HasName("IndiceDepartamentoPais");

                entity.Property(e => e.CodigoDane)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdPais)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrEquiposRadiacion>(entity =>
            {
                entity.HasKey(e => e.IdEquipo)
                    .HasName("PRIMARY");

                entity.ToTable("pr_equipos_radiacion");

                entity.HasIndex(e => e.IdEquipo)
                    .HasName("id_equipo");

                entity.Property(e => e.IdEquipo).HasColumnName("id_equipo");

                entity.Property(e => e.DescEquipo)
                    .IsRequired()
                    .HasColumnName("desc_equipo")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrEstadoTramite>(entity =>
            {
                entity.HasKey(e => e.IdEstado)
                    .HasName("PRIMARY");

                entity.ToTable("pr_estado_tramite");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrEstadocivil>(entity =>
            {
                entity.HasKey(e => e.IdEstadoCivil)
                    .HasName("PRIMARY");

                entity.ToTable("pr_estadocivil");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrEtnia>(entity =>
            {
                entity.HasKey(e => e.IdEtnia)
                    .HasName("PRIMARY");

                entity.ToTable("pr_etnia");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrFaqtips>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pr_faqtips");

                entity.Property(e => e.Categoria)
                    .HasColumnName("categoria")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("timestamp(1)");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.IdFaq).HasColumnName("id_faq");

                entity.Property(e => e.IdTramite).HasColumnName("id_tramite");

                entity.Property(e => e.Pregunta)
                    .IsRequired()
                    .HasColumnName("pregunta")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Respuesta)
                    .IsRequired()
                    .HasColumnName("respuesta");

                entity.Property(e => e.TipoFaqs)
                    .HasColumnName("tipo_faqs")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.Tips)
                    .IsRequired()
                    .HasColumnName("tips")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrInstitucion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pr_institucion");

                entity.Property(e => e.IdInstitucion).HasColumnName("id_institucion");

                entity.Property(e => e.NombreInstitucion)
                    .IsRequired()
                    .HasColumnName("nombre_institucion")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Sede)
                    .IsRequired()
                    .HasColumnName("sede")
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrLocalidad>(entity =>
            {
                entity.HasKey(e => e.IdLocalidad)
                    .HasName("PRIMARY");

                entity.ToTable("pr_localidad");

                entity.Property(e => e.IdLocalidad).HasColumnName("idLocalidad");

                entity.Property(e => e.IdSubred).HasColumnName("id_subred");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrMunicipio>(entity =>
            {
                entity.HasKey(e => e.IdMunicipio)
                    .HasName("PRIMARY");

                entity.ToTable("pr_municipio");

                entity.HasIndex(e => e.IdDepartamento)
                    .HasName("IndexMunicipioDepartamento");

                entity.Property(e => e.CodigoDane)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrNivelacademico>(entity =>
            {
                entity.HasKey(e => e.IdNivelAcademico)
                    .HasName("PRIMARY");

                entity.ToTable("pr_nivelacademico");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrNiveleducativo>(entity =>
            {
                entity.HasKey(e => e.IdNivelEducativo)
                    .HasName("PRIMARY");

                entity.ToTable("pr_niveleducativo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrOpcion>(entity =>
            {
                entity.HasKey(e => e.IdOpcion)
                    .HasName("PRIMARY");

                entity.ToTable("pr_opcion");

                entity.HasIndex(e => e.IdPregunta)
                    .HasName("IndiceOpcionPregunta");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPreguntaNavigation)
                    .WithMany(p => p.PrOpcion)
                    .HasForeignKey(d => d.IdPregunta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pr_Opcion_ibfk_1");
            });

            modelBuilder.Entity<PrPais>(entity =>
            {
                entity.HasKey(e => e.IdPais)
                    .HasName("PRIMARY");

                entity.ToTable("pr_pais");

                entity.Property(e => e.IdPais)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrPerfil>(entity =>
            {
                entity.HasKey(e => e.IdPerfil)
                    .HasName("PRIMARY");

                entity.ToTable("pr_perfil");

                entity.Property(e => e.IdPerfil).HasColumnName("id_perfil");

                entity.Property(e => e.DescPerfil)
                    .IsRequired()
                    .HasColumnName("desc_perfil")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasColumnName("estado");
            });

            modelBuilder.Entity<PrPregunta>(entity =>
            {
                entity.HasKey(e => e.IdPregunta)
                    .HasName("PRIMARY");

                entity.ToTable("pr_pregunta");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(512)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrPrestadorservicio>(entity =>
            {
                entity.HasKey(e => e.IdPrestadorServicio)
                    .HasName("PRIMARY");

                entity.ToTable("pr_prestadorservicio");

                entity.HasIndex(e => e.IdSubRed)
                    .HasName("IndicePrestadorServicioSubRed");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdSubRedNavigation)
                    .WithMany(p => p.PrPrestadorservicio)
                    .HasForeignKey(d => d.IdSubRed)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pr_PrestadorServicio_ibfk_1");
            });

            modelBuilder.Entity<PrPrograma>(entity =>
            {
                entity.HasKey(e => e.IdPrograma)
                    .HasName("PRIMARY");

                entity.ToTable("pr_programa");

                entity.Property(e => e.IdPrograma).HasColumnName("id_programa");

                entity.Property(e => e.DescPrograma)
                    .IsRequired()
                    .HasColumnName("desc_programa")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrProgramaEquivalente>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pr_programa_equivalente");

                entity.Property(e => e.AplicaRethus).HasColumnName("aplica_rethus");

                entity.Property(e => e.GrupoTituloequi)
                    .IsRequired()
                    .HasColumnName("grupo_tituloequi")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdProgramaequi).HasColumnName("id_programaequi");

                entity.Property(e => e.NombrePrograma)
                    .IsRequired()
                    .HasColumnName("nombre_programa")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoProg)
                    .IsRequired()
                    .HasColumnName("tipo_prog")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrProgramasUniv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pr_programas_univ");

                entity.Property(e => e.AplicaRethus).HasColumnName("aplica_rethus");

                entity.Property(e => e.IdInstitucion).HasColumnName("id_institucion");

                entity.Property(e => e.IdPrograma)
                    .IsRequired()
                    .HasColumnName("id_programa")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.NombrePrograma)
                    .IsRequired()
                    .HasColumnName("nombre_programa");

                entity.Property(e => e.Sede)
                    .IsRequired()
                    .HasColumnName("sede")
                    .HasMaxLength(130)
                    .IsUnicode(false);

                entity.Property(e => e.TipoProg)
                    .HasColumnName("tipo_prog")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrPuntoatencion>(entity =>
            {
                entity.HasKey(e => e.IdPunto)
                    .HasName("PRIMARY");

                entity.ToTable("pr_puntoatencion");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Horario)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdSubred).HasColumnName("id_subred");

                entity.Property(e => e.NombrePunto)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrRayosxEstadoTramite>(entity =>
            {
                entity.HasKey(e => e.IdEstado)
                    .HasName("PRIMARY");

                entity.ToTable("pr_rayosx_estado_tramite");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrRayosxItemsInfra>(entity =>
            {
                entity.HasKey(e => e.IdItem)
                    .HasName("PRIMARY");

                entity.ToTable("pr_rayosx_items_infra");

                entity.Property(e => e.IdItem).HasColumnName("id_item");

                entity.Property(e => e.DescItem)
                    .IsRequired()
                    .HasColumnName("desc_item");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.IdResolucion).HasColumnName("id_resolucion");
            });

            modelBuilder.Entity<PrRazonAsistencia>(entity =>
            {
                entity.HasKey(e => e.IdRazonAsistencia)
                    .HasName("PRIMARY");

                entity.ToTable("pr_razon_asistencia");

                entity.Property(e => e.IdRazonAsistencia).HasColumnName("id_razon_asistencia");

                entity.Property(e => e.DescRazonAsistencia)
                    .IsRequired()
                    .HasColumnName("desc_razon_asistencia")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrRazonSeguimiento>(entity =>
            {
                entity.HasKey(e => e.IdRazonSeguimiento)
                    .HasName("PRIMARY");

                entity.ToTable("pr_razon_seguimiento");

                entity.Property(e => e.IdRazonSeguimiento).HasColumnName("id_razon_seguimiento");

                entity.Property(e => e.DescRazonSeguimiento)
                    .IsRequired()
                    .HasColumnName("desc_razon_seguimiento")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrResponsablecuidado>(entity =>
            {
                entity.HasKey(e => e.IdResponsableCuidado)
                    .HasName("PRIMARY");

                entity.ToTable("pr_responsablecuidado");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrSexo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pr_sexo");

                entity.Property(e => e.DescripcionSexo)
                    .HasColumnName("descripcion_sexo")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.IdSexo).HasColumnName("id_sexo");
            });

            modelBuilder.Entity<PrSubred>(entity =>
            {
                entity.HasKey(e => e.IdSubRed)
                    .HasName("PRIMARY");

                entity.ToTable("pr_subred");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrTipoSeguimiento>(entity =>
            {
                entity.HasKey(e => e.IdTipoSeguimiento)
                    .HasName("PRIMARY");

                entity.ToTable("pr_tipo_seguimiento");

                entity.Property(e => e.IdTipoSeguimiento).HasColumnName("id_tipo_seguimiento");

                entity.Property(e => e.DescTipoSeguimiento)
                    .IsRequired()
                    .HasColumnName("desc_tipo_seguimiento")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrTipoVisualizacion>(entity =>
            {
                entity.HasKey(e => e.IdTipoVisualizacion)
                    .HasName("PRIMARY");

                entity.ToTable("pr_tipo_visualizacion");

                entity.HasIndex(e => e.IdTipoVisualizacion)
                    .HasName("id_tipo_visualizacion");

                entity.Property(e => e.IdTipoVisualizacion).HasColumnName("id_tipo_visualizacion");

                entity.Property(e => e.DescTipoVisualizacion)
                    .IsRequired()
                    .HasColumnName("desc_tipo_visualizacion")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrTipoidentificacion>(entity =>
            {
                entity.HasKey(e => e.IdTipoIdentificacion)
                    .HasName("PRIMARY");

                entity.ToTable("pr_tipoidentificacion");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrUpz>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pr_upz");

                entity.Property(e => e.CodUpz).HasColumnName("cod_upz");

                entity.Property(e => e.IdLocalidad).HasColumnName("id_localidad");

                entity.Property(e => e.IdUpz).HasColumnName("id_upz");

                entity.Property(e => e.NomUpz).HasColumnName("nom_upz");
            });

            modelBuilder.Entity<RayosxCategoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoriaRayosx)
                    .HasName("PRIMARY");

                entity.ToTable("rayosx_categoria");

                entity.HasComment("Tabla equipos de rayos X");

                entity.HasIndex(e => e.IdTramiteRayosx)
                    .HasName("id_tramite_rayosx")
                    .IsUnique();

                entity.Property(e => e.IdCategoriaRayosx).HasColumnName("id_categoria_rayosx");

                entity.Property(e => e.Categoria).HasColumnName("categoria");

                entity.Property(e => e.Categoria1).HasColumnName("categoria1");

                entity.Property(e => e.Categoria11).HasColumnName("categoria1_1");

                entity.Property(e => e.Categoria12).HasColumnName("categoria1_2");

                entity.Property(e => e.Categoria2).HasColumnName("categoria2");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.IdTramiteRayosx).HasColumnName("id_tramite_rayosx");

                entity.Property(e => e.TipoVisualizacion).HasColumnName("tipo_visualizacion");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<RayosxDireccion>(entity =>
            {
                entity.HasKey(e => e.IdDireccionRayosx)
                    .HasName("PRIMARY");

                entity.ToTable("rayosx_direccion");

                entity.HasComment("Tabla direccion entidad Rayos X");

                entity.Property(e => e.IdDireccionRayosx).HasColumnName("id_direccion_rayosx");

                entity.Property(e => e.CelularEntidad)
                    .IsRequired()
                    .HasColumnName("celular_entidad")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.DeptoEntidad).HasColumnName("depto_entidad");

                entity.Property(e => e.DireEntidad)
                    .IsRequired()
                    .HasColumnName("dire_entidad")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmailEntidad)
                    .IsRequired()
                    .HasColumnName("email_entidad")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ExtensionEntidad)
                    .IsRequired()
                    .HasColumnName("extension_entidad")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdTramiteRayosx).HasColumnName("id_tramite_rayosx");

                entity.Property(e => e.IndicativoEntidad)
                    .HasColumnName("indicativo_entidad")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MpioEntidad).HasColumnName("mpio_entidad");

                entity.Property(e => e.SedeEntidad)
                    .IsRequired()
                    .HasColumnName("sede_entidad")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoEntidad)
                    .IsRequired()
                    .HasColumnName("telefono_entidad")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<RayosxDirector>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rayosx_director");

                entity.HasComment("Tabla director tecnico rayos x");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IdDirectorRayosx).HasColumnName("id_director_rayosx");

                entity.Property(e => e.IdTramiteRayosx).HasColumnName("id_tramite_rayosx");

                entity.Property(e => e.TalentoCorreo)
                    .IsRequired()
                    .HasColumnName("talento_correo")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TalentoFechaConvalida)
                    .IsRequired()
                    .HasColumnName("talento_fecha_convalida")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TalentoFechaConvalidaPos)
                    .HasColumnName("talento_fecha_convalida_pos")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TalentoFechaDiploma)
                    .IsRequired()
                    .HasColumnName("talento_fecha_diploma")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TalentoFechaDiplomaPos)
                    .HasColumnName("talento_fecha_diploma_pos")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TalentoLexpedicion)
                    .IsRequired()
                    .HasColumnName("talento_lexpedicion")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TalentoLibro)
                    .IsRequired()
                    .HasColumnName("talento_libro")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TalentoLibroPos)
                    .HasColumnName("talento_libro_pos")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TalentoNdocumento)
                    .IsRequired()
                    .HasColumnName("talento_ndocumento")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TalentoNivel)
                    .IsRequired()
                    .HasColumnName("talento_nivel")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TalentoPapellido)
                    .IsRequired()
                    .HasColumnName("talento_papellido")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TalentoPnombre)
                    .IsRequired()
                    .HasColumnName("talento_pnombre")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TalentoRegistro)
                    .IsRequired()
                    .HasColumnName("talento_registro")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TalentoRegistroPos)
                    .HasColumnName("talento_registro_pos")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TalentoResolucion)
                    .IsRequired()
                    .HasColumnName("talento_resolucion")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TalentoResolucionPos)
                    .HasColumnName("talento_resolucion_pos")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TalentoSapellido)
                    .IsRequired()
                    .HasColumnName("talento_sapellido")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TalentoSnombre)
                    .IsRequired()
                    .HasColumnName("talento_snombre")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TalentoTdocumento).HasColumnName("talento_tdocumento");

                entity.Property(e => e.TalentoTitulo)
                    .IsRequired()
                    .HasColumnName("talento_titulo")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TalentoTituloPos)
                    .IsRequired()
                    .HasColumnName("talento_titulo_pos")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TalentoUniversidad)
                    .IsRequired()
                    .HasColumnName("talento_universidad")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TalentoUniversidadPos)
                    .IsRequired()
                    .HasColumnName("talento_universidad_pos")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<RayosxDocumentos>(entity =>
            {
                entity.HasKey(e => e.IdDocumentosRayosx)
                    .HasName("PRIMARY");

                entity.ToTable("rayosx_documentos");

                entity.HasComment("Tabla documentos adjuntos");

                entity.Property(e => e.IdDocumentosRayosx).HasColumnName("id_documentos_rayosx");

                entity.Property(e => e.Categoria).HasColumnName("categoria");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Documento)
                    .IsRequired()
                    .HasColumnName("documento")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasMaxLength(2)
                    .IsFixedLength();

                entity.Property(e => e.IdArchivo).HasColumnName("id_archivo");

                entity.Property(e => e.IdTramiteRayosx).HasColumnName("id_tramite_rayosx");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasColumnName("path")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<RayosxEncargado>(entity =>
            {
                entity.HasKey(e => e.IdEncargadoRayosx)
                    .HasName("PRIMARY");

                entity.ToTable("rayosx_encargado");

                entity.HasComment("Tabla encargado de proteccion");

                entity.Property(e => e.IdEncargadoRayosx).HasColumnName("id_encargado_rayosx");

                entity.Property(e => e.EncargadoCorreo)
                    .IsRequired()
                    .HasColumnName("encargado_correo")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EncargadoLexpedicion)
                    .IsRequired()
                    .HasColumnName("encargado_lexpedicion")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EncargadoNdocumento)
                    .IsRequired()
                    .HasColumnName("encargado_ndocumento")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EncargadoNivel).HasColumnName("encargado_nivel");

                entity.Property(e => e.EncargadoPapellido)
                    .IsRequired()
                    .HasColumnName("encargado_papellido")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EncargadoPnombre)
                    .IsRequired()
                    .HasColumnName("encargado_pnombre")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EncargadoProfesion)
                    .IsRequired()
                    .HasColumnName("encargado_profesion")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EncargadoSapellido)
                    .IsRequired()
                    .HasColumnName("encargado_sapellido")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EncargadoSnombre)
                    .IsRequired()
                    .HasColumnName("encargado_snombre")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EncargadoTdocumento).HasColumnName("encargado_tdocumento");

                entity.Property(e => e.IdTramiteRayosx).HasColumnName("id_tramite_rayosx");
            });

            modelBuilder.Entity<RayosxEquipoInfra>(entity =>
            {
                entity.HasKey(e => e.IdEquipoInfra)
                    .HasName("PRIMARY");

                entity.ToTable("rayosx_equipo_infra");

                entity.HasIndex(e => new { e.IdEquipo, e.IdTramite, e.IdItem, e.IdEstado })
                    .HasName("id_equipo")
                    .IsUnique();

                entity.Property(e => e.IdEquipoInfra).HasColumnName("id_equipo_infra");

                entity.Property(e => e.FechaObservacion)
                    .HasColumnName("fecha_observacion")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IdEquipo).HasColumnName("id_equipo");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.IdItem).HasColumnName("id_item");

                entity.Property(e => e.IdTramite).HasColumnName("id_tramite");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasColumnName("observaciones");
            });

            modelBuilder.Entity<RayosxEquipos>(entity =>
            {
                entity.HasKey(e => e.IdEquipoRayosx)
                    .HasName("PRIMARY");

                entity.ToTable("rayosx_equipos");

                entity.HasComment("Tabla equipos de rayos X");

                entity.Property(e => e.IdEquipoRayosx).HasColumnName("id_equipo_rayosx");

                entity.Property(e => e.AnioFabricacion)
                    .IsRequired()
                    .HasColumnName("anio_fabricacion")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AnioFabricacionTubo)
                    .IsRequired()
                    .HasColumnName("anio_fabricacion_tubo")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AnioFabricacionTubo2)
                    .HasColumnName("anio_fabricacion_tubo2")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CargaTrabajo)
                    .HasColumnName("carga_trabajo")
                    .HasColumnType("decimal(7,4)");

                entity.Property(e => e.CargaTrabajo2)
                    .HasColumnName("carga_trabajo2")
                    .HasColumnType("decimal(7,4)");

                entity.Property(e => e.Categoria1).HasColumnName("categoria1");

                entity.Property(e => e.Categoria11).HasColumnName("categoria1_1");

                entity.Property(e => e.Categoria12).HasColumnName("categoria1_2");

                entity.Property(e => e.Categoria2).HasColumnName("categoria2");

                entity.Property(e => e.Categoria21).HasColumnName("categoria2_1");

                entity.Property(e => e.ContieneTuboRx)
                    .HasColumnName("contiene_tubo_rx")
                    .HasColumnType("decimal(7,4)");

                entity.Property(e => e.ContieneTuboRx2)
                    .HasColumnName("contiene_tubo_rx2")
                    .HasColumnType("decimal(7,4)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.EnergiaElectrones)
                    .HasColumnName("energia_electrones")
                    .HasColumnType("decimal(7,4)");

                entity.Property(e => e.EnergiaElectrones2)
                    .HasColumnName("energia_electrones2")
                    .HasColumnType("decimal(7,4)");

                entity.Property(e => e.EnergiaFotones)
                    .HasColumnName("energia_fotones")
                    .HasColumnType("decimal(7,4)");

                entity.Property(e => e.EnergiaFotones2)
                    .HasColumnName("energia_fotones2")
                    .HasColumnType("decimal(7,4)");

                entity.Property(e => e.EquipoGenerador).HasColumnName("equipo_generador");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FiBlindajes).HasColumnName("fi_blindajes");

                entity.Property(e => e.FiBlindajes2).HasColumnName("fi_blindajes2");

                entity.Property(e => e.FiControlCalidad).HasColumnName("fi_control_calidad");

                entity.Property(e => e.FiControlCalidad2).HasColumnName("fi_control_calidad2");

                entity.Property(e => e.FiPlano).HasColumnName("fi_plano");

                entity.Property(e => e.FiPruebasCaracterizacion).HasColumnName("fi_pruebas_caracterizacion");

                entity.Property(e => e.FiPruebasCaracterizacion2).HasColumnName("fi_pruebas_caracterizacion2");

                entity.Property(e => e.IdTramiteRayosx).HasColumnName("id_tramite_rayosx");

                entity.Property(e => e.MarcaEquipo)
                    .IsRequired()
                    .HasColumnName("marca_equipo")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MarcaTuboRx)
                    .IsRequired()
                    .HasColumnName("marca_tubo_rx")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MarcaTuboRx2)
                    .HasColumnName("marca_tubo_rx2")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModeloEquipo)
                    .IsRequired()
                    .HasColumnName("modelo_equipo")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModeloTuboRx)
                    .IsRequired()
                    .HasColumnName("modelo_tubo_rx")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModeloTuboRx2)
                    .HasColumnName("modelo_tubo_rx2")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroPermiso)
                    .HasColumnName("numero_permiso")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OtroEquipo)
                    .HasColumnName("otro_equipo")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SerieEquipo)
                    .IsRequired()
                    .HasColumnName("serie_equipo")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SerieTuboRx)
                    .IsRequired()
                    .HasColumnName("serie_tubo_rx")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SerieTuboRx2)
                    .HasColumnName("serie_tubo_rx2")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TensionTuboRx)
                    .HasColumnName("tension_tubo_rx")
                    .HasColumnType("decimal(7,4)");

                entity.Property(e => e.TensionTuboRx2)
                    .HasColumnName("tension_tubo_rx2")
                    .HasColumnType("decimal(7,4)");

                entity.Property(e => e.TipoVisualizacion).HasColumnName("tipo_visualizacion");

                entity.Property(e => e.UbicacionEquipo)
                    .IsRequired()
                    .HasColumnName("ubicacion_equipo")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<RayosxObjprueba>(entity =>
            {
                entity.HasKey(e => e.IdObjRayosx)
                    .HasName("PRIMARY");

                entity.ToTable("rayosx_objprueba");

                entity.Property(e => e.IdObjRayosx).HasColumnName("id_obj_rayosx");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IdTramiteRayosx).HasColumnName("id_tramite_rayosx");

                entity.Property(e => e.ObjCalibracion)
                    .IsRequired()
                    .HasColumnName("obj_calibracion")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ObjFecha)
                    .IsRequired()
                    .HasColumnName("obj_fecha")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ObjManual).HasColumnName("obj_manual");

                entity.Property(e => e.ObjMarca)
                    .IsRequired()
                    .HasColumnName("obj_marca")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ObjModelo)
                    .IsRequired()
                    .HasColumnName("obj_modelo")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ObjNombre)
                    .IsRequired()
                    .HasColumnName("obj_nombre")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ObjSerie)
                    .IsRequired()
                    .HasColumnName("obj_serie")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ObjUso)
                    .IsRequired()
                    .HasColumnName("obj_uso")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ObjVigencia).HasColumnName("obj_vigencia");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<RayosxResoluciones>(entity =>
            {
                entity.HasKey(e => new { e.IdResolucion, e.Anio })
                    .HasName("PRIMARY");

                entity.ToTable("rayosx_resoluciones");

                entity.Property(e => e.IdResolucion)
                    .HasColumnName("id_resolucion")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.CodiTramite)
                    .IsRequired()
                    .HasColumnName("codi_tramite")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'B'");

                entity.Property(e => e.CodigoVerificacion)
                    .IsRequired()
                    .HasColumnName("codigo_verificacion")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.IdArchivo).HasColumnName("id_archivo");

                entity.Property(e => e.IdTramite).HasColumnName("id_tramite");
            });

            modelBuilder.Entity<RayosxTipoTramite>(entity =>
            {
                entity.ToTable("rayosx_tipo_tramite");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(191)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");
            });

            modelBuilder.Entity<RayosxToe>(entity =>
            {
                entity.HasKey(e => e.IdToeRayosx)
                    .HasName("PRIMARY");

                entity.ToTable("rayosx_toe");

                entity.HasComment("Tabla TOE rayos x");

                entity.Property(e => e.IdToeRayosx).HasColumnName("id_toe_rayosx");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.IdTramiteRayosx).HasColumnName("id_tramite_rayosx");

                entity.Property(e => e.ToeCorreo)
                    .IsRequired()
                    .HasColumnName("toe_correo")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ToeLexpedicion)
                    .IsRequired()
                    .HasColumnName("toe_lexpedicion")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ToeNdocumento)
                    .IsRequired()
                    .HasColumnName("toe_ndocumento")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ToeNivel).HasColumnName("toe_nivel");

                entity.Property(e => e.ToePapellido)
                    .IsRequired()
                    .HasColumnName("toe_papellido")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ToePnombre)
                    .IsRequired()
                    .HasColumnName("toe_pnombre")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ToeProEntrenamiento)
                    .HasColumnName("toe_pro_entrenamiento")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ToeProfesion)
                    .IsRequired()
                    .HasColumnName("toe_profesion")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ToeRegistro)
                    .HasColumnName("toe_registro")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ToeSapellido)
                    .IsRequired()
                    .HasColumnName("toe_sapellido")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ToeSnombre)
                    .IsRequired()
                    .HasColumnName("toe_snombre")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ToeTdocumento).HasColumnName("toe_tdocumento");

                entity.Property(e => e.ToeTipo).HasColumnName("toe_tipo");

                entity.Property(e => e.ToeUltEntrenamiento)
                    .HasColumnName("toe_ult_entrenamiento")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<RayosxTramite>(entity =>
            {
                entity.ToTable("rayosx_tramite");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint unsigned");

                entity.Property(e => e.ArchivoVisita).HasColumnName("archivo_visita");

                entity.Property(e => e.Categoria).HasColumnName("categoria");

                entity.Property(e => e.CorreoNotificacion)
                    .HasColumnName("correo_notificacion")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasColumnType("tinyint(1)");

                entity.Property(e => e.FechaEnvio).HasColumnName("fecha_envio");

                entity.Property(e => e.FechaEnvioSubsanacion1).HasColumnName("fecha_envio_subsanacion1");

                entity.Property(e => e.FechaEnvioSubsanacion2).HasColumnName("fecha_envio_subsanacion2");

                entity.Property(e => e.FechaSubsanacion1).HasColumnName("fecha_subsanacion1");

                entity.Property(e => e.FechaSubsanacion2).HasColumnName("fecha_subsanacion2");

                entity.Property(e => e.Modulo1).HasColumnName("modulo1");

                entity.Property(e => e.Modulo2).HasColumnName("modulo2");

                entity.Property(e => e.Modulo3).HasColumnName("modulo3");

                entity.Property(e => e.Modulo4).HasColumnName("modulo4");

                entity.Property(e => e.Modulo5).HasColumnName("modulo5");

                entity.Property(e => e.Notificacion)
                    .HasColumnName("notificacion")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.SolicitaProrroga).HasColumnName("solicita_prorroga");

                entity.Property(e => e.TipoTramite)
                    .HasColumnName("tipo_tramite")
                    .HasColumnType("int unsigned");

                entity.Property(e => e.UpdatedAt).HasColumnName("updated_at");

                entity.Property(e => e.User)
                    .HasColumnName("user")
                    .HasColumnType("bigint unsigned");

                entity.Property(e => e.VisitaPrevia).HasColumnName("visita_previa");
            });

            modelBuilder.Entity<RayosxTramiteFlujo>(entity =>
            {
                entity.ToTable("rayosx_tramite_flujo");

                entity.HasIndex(e => e.TramiteId)
                    .HasName("rayosx_tramite_flujo_tramite_id_foreign");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint unsigned");

                entity.Property(e => e.FechaEstado)
                    .HasColumnName("fecha_estado")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IdArchivo).HasColumnName("id_archivo");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasColumnName("observaciones");

                entity.Property(e => e.TramiteId)
                    .HasColumnName("tramite_id")
                    .HasColumnType("bigint unsigned");
            });

            modelBuilder.Entity<RayosxValidacion>(entity =>
            {
                entity.HasKey(e => e.IdValidacion)
                    .HasName("PRIMARY");

                entity.ToTable("rayosx_validacion");

                entity.Property(e => e.IdValidacion).HasColumnName("id_validacion");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.IdTramite).HasColumnName("id_tramite");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Observaciones1)
                    .IsRequired()
                    .HasColumnName("observaciones1");

                entity.Property(e => e.Observaciones2)
                    .IsRequired()
                    .HasColumnName("observaciones2");

                entity.Property(e => e.Observaciones3)
                    .IsRequired()
                    .HasColumnName("observaciones3");

                entity.Property(e => e.Observaciones4)
                    .IsRequired()
                    .HasColumnName("observaciones4");

                entity.Property(e => e.Observaciones5)
                    .IsRequired()
                    .HasColumnName("observaciones5");

                entity.Property(e => e.Observaciones6)
                    .IsRequired()
                    .HasColumnName("observaciones6");
            });

            modelBuilder.Entity<RegistroRayosx>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PRIMARY");

                entity.ToTable("registro_rayosx");

                entity.Property(e => e.IdRegistro).HasColumnName("id_registro");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaTramite).HasColumnName("fecha_tramite");

                entity.Property(e => e.IdPersona).HasColumnName("id_persona");
            });

            modelBuilder.Entity<RegistroTitulo>(entity =>
            {
                entity.HasKey(e => e.IdTitulo)
                    .HasName("PRIMARY");

                entity.ToTable("registro_titulo");

                entity.Property(e => e.IdTitulo).HasColumnName("id_titulo");

                entity.Property(e => e.Acta)
                    .HasColumnName("acta")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.CodUniversidad)
                    .HasColumnName("cod_universidad")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Diploma)
                    .HasColumnName("diploma")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Entidad).HasColumnName("entidad");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.FechaAclaracion)
                    .HasColumnName("fecha_aclaracion")
                    .HasColumnType("date");

                entity.Property(e => e.FechaEditado)
                    .HasColumnName("fecha_editado")
                    .HasColumnType("date");

                entity.Property(e => e.FechaReposicion)
                    .HasColumnName("fecha_reposicion")
                    .HasColumnType("date");

                entity.Property(e => e.FechaResolucion)
                    .HasColumnName("fecha_resolucion")
                    .HasColumnType("date");

                entity.Property(e => e.FechaTerm)
                    .HasColumnName("fecha_term")
                    .HasColumnType("date");

                entity.Property(e => e.FechaTermExt)
                    .HasColumnName("fecha_term_ext")
                    .HasColumnType("date");

                entity.Property(e => e.FechaTramite).HasColumnName("fecha_tramite");

                entity.Property(e => e.Folio)
                    .HasColumnName("folio")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdPersona).HasColumnName("id_persona");

                entity.Property(e => e.InstitucionEducativa).HasColumnName("institucion_educativa");

                entity.Property(e => e.Libro)
                    .HasColumnName("libro")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaisTituloequi).HasColumnName("pais_tituloequi");

                entity.Property(e => e.PdfActa).HasColumnName("pdf_acta");

                entity.Property(e => e.PdfDocumento).HasColumnName("pdf_documento");

                entity.Property(e => e.PdfResolucion).HasColumnName("pdf_resolucion");

                entity.Property(e => e.PdfTarjeta).HasColumnName("pdf_tarjeta");

                entity.Property(e => e.PdfTitulo).HasColumnName("pdf_titulo");

                entity.Property(e => e.Profesion).HasColumnName("profesion");

                entity.Property(e => e.Resolucion)
                    .HasColumnName("resolucion")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tarjeta)
                    .HasColumnName("tarjeta")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Terminos).HasColumnName("terminos");

                entity.Property(e => e.TipoTitulo).HasColumnName("tipo_titulo");

                entity.Property(e => e.TituloEquivalente)
                    .HasColumnName("titulo_equivalente")
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ResolucionesTitulo>(entity =>
            {
                entity.HasKey(e => new { e.IdResolucion, e.Anio })
                    .HasName("PRIMARY");

                entity.ToTable("resoluciones_titulo");

                entity.Property(e => e.IdResolucion)
                    .HasColumnName("id_resolucion")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.CodiTramite)
                    .IsRequired()
                    .HasColumnName("codi_tramite")
                    .HasMaxLength(1)
                    .IsFixedLength()
                    .HasDefaultValueSql("'A'");

                entity.Property(e => e.CodigoVerificacion)
                    .IsRequired()
                    .HasColumnName("codigo_verificacion")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.IdArchivo).HasColumnName("id_archivo");

                entity.Property(e => e.IdTitulo).HasColumnName("id_titulo");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PRIMARY");

                entity.ToTable("roles");

                entity.Property(e => e.IdRol).HasColumnName("id_rol");

                entity.Property(e => e.DescRol)
                    .IsRequired()
                    .HasColumnName("desc_rol")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasMaxLength(2)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SeguimientoTramite>(entity =>
            {
                entity.HasKey(e => e.IdSeguimiento)
                    .HasName("PRIMARY");

                entity.ToTable("seguimiento_tramite");

                entity.HasIndex(e => new { e.IdTitulo, e.IdConsecutivo })
                    .HasName("id_titulo")
                    .IsUnique();

                entity.Property(e => e.IdSeguimiento).HasColumnName("id_seguimiento");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaRegistro).HasColumnName("fecha_registro");

                entity.Property(e => e.IdConsecutivo).HasColumnName("id_consecutivo");

                entity.Property(e => e.IdTitulo).HasColumnName("id_titulo");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Observaciones)
                    .HasColumnName("observaciones")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Tipomotivoaclaracion).HasColumnName("tipomotivoaclaracion");
            });

            modelBuilder.Entity<SstRegistro>(entity =>
            {
                entity.HasKey(e => e.IdRegistro)
                    .HasName("PRIMARY");

                entity.ToTable("sst_registro");

                entity.Property(e => e.IdRegistro).HasColumnName("id_registro");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasColumnName("area");

                entity.Property(e => e.Caracteristicas)
                    .IsRequired()
                    .HasColumnName("caracteristicas");

                entity.Property(e => e.DeptoEmpresa).HasColumnName("depto_empresa");

                entity.Property(e => e.DirEmpresa)
                    .HasColumnName("dir_empresa")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DocCc).HasColumnName("doc_cc");

                entity.Property(e => e.DocConvalidacion).HasColumnName("doc_convalidacion");

                entity.Property(e => e.DocDocuIden).HasColumnName("doc_docu_iden");

                entity.Property(e => e.DocFormatoEquipos).HasColumnName("doc_formato_equipos");

                entity.Property(e => e.DocFormatoPersonas).HasColumnName("doc_formato_personas");

                entity.Property(e => e.DocPensum).HasColumnName("doc_pensum");

                entity.Property(e => e.DocPostgrado).HasColumnName("doc_postgrado");

                entity.Property(e => e.DocPregrado).HasColumnName("doc_pregrado");

                entity.Property(e => e.DocRl).HasColumnName("doc_rl");

                entity.Property(e => e.DocSoporte).HasColumnName("doc_soporte");

                entity.Property(e => e.FaxEmpresa)
                    .HasColumnName("fax_empresa")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdTramite).HasColumnName("id_tramite");

                entity.Property(e => e.Labora)
                    .HasColumnName("labora")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.MpioEmpresa).HasColumnName("mpio_empresa");

                entity.Property(e => e.NombreEmpresa)
                    .HasColumnName("nombre_empresa")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.OtroTipoProfesional).HasColumnName("otro_tipo_profesional");

                entity.Property(e => e.Otros)
                    .IsRequired()
                    .HasColumnName("otros");

                entity.Property(e => e.Servicios)
                    .IsRequired()
                    .HasColumnName("servicios");

                entity.Property(e => e.TelEmpresa)
                    .HasColumnName("tel_empresa")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TipoProfesional).HasColumnName("tipo_profesional");

                entity.Property(e => e.TipoPrograma).HasColumnName("tipo_programa");

                entity.Property(e => e.TipoTitulo).HasColumnName("tipo_titulo");

                entity.Property(e => e.TituloPrograma)
                    .HasColumnName("titulo_programa")
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SstTramite>(entity =>
            {
                entity.HasKey(e => e.IdTramite)
                    .HasName("PRIMARY");

                entity.ToTable("sst_tramite");

                entity.Property(e => e.IdTramite).HasColumnName("id_tramite");

                entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");

                entity.Property(e => e.IdDeptoRenovacion).HasColumnName("id_depto_renovacion");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.IdLicenciaAnt).HasColumnName("id_licencia_ant");

                entity.Property(e => e.IdMotivoModificacion).HasColumnName("id_motivo_modificacion");

                entity.Property(e => e.IdMpioRenovacion).HasColumnName("id_mpio_renovacion");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.TipoTramite).HasColumnName("tipo_tramite");
            });

            modelBuilder.Entity<SstTramiteFlujo>(entity =>
            {
                entity.ToTable("sst_tramite_flujo");

                entity.HasIndex(e => e.TramiteId)
                    .HasName("rayosx_tramite_flujo_tramite_id_foreign");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint unsigned");

                entity.Property(e => e.FechaEstado)
                    .HasColumnName("fecha_estado")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.IdArchivo).HasColumnName("id_archivo");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Observaciones)
                    .IsRequired()
                    .HasColumnName("observaciones");

                entity.Property(e => e.TramiteId)
                    .HasColumnName("tramite_id")
                    .HasColumnType("bigint unsigned");
            });

            modelBuilder.Entity<Subredes>(entity =>
            {
                entity.HasKey(e => e.IdSubred)
                    .HasName("PRIMARY");

                entity.ToTable("subredes");

                entity.Property(e => e.IdSubred).HasColumnName("id_subred");

                entity.Property(e => e.DescSubred)
                    .IsRequired()
                    .HasColumnName("desc_subred")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoSr)
                    .IsRequired()
                    .HasColumnName("estado_sr")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'AC'");
            });

            modelBuilder.Entity<TodosLosTramites>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("todos_los_tramites");

                entity.Property(e => e.DescEstado)
                    .IsRequired()
                    .HasColumnName("descEstado")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DescTipoIden)
                    .IsRequired()
                    .HasColumnName("descTipoIden")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.FechReso).HasColumnName("fech_reso");

                entity.Property(e => e.FechaTramite).HasColumnName("fecha_tramite");

                entity.Property(e => e.IdTitulo).HasColumnName("id_titulo");

                entity.Property(e => e.NumeIdentificacion).HasColumnName("nume_identificacion");

                entity.Property(e => e.PApellido)
                    .HasColumnName("p_apellido")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PNombre)
                    .IsRequired()
                    .HasColumnName("p_nombre")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SApellido)
                    .HasColumnName("s_apellido")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SNombre)
                    .IsRequired()
                    .HasColumnName("s_nombre")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.TipoTitulo).HasColumnName("tipo_titulo");
            });

            modelBuilder.Entity<Tramites>(entity =>
            {
                entity.HasKey(e => e.IdTramite)
                    .HasName("PRIMARY");

                entity.ToTable("tramites");

                entity.Property(e => e.IdTramite).HasColumnName("id_tramite");

                entity.Property(e => e.DescTramite)
                    .IsRequired()
                    .HasColumnName("desc_tramite")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasMaxLength(2)
                    .IsFixedLength();
            });

            modelBuilder.Entity<TsAuditoriapersona>(entity =>
            {
                entity.ToTable("ts_auditoriapersona");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AnteriorNombre)
                    .HasColumnName("anterior_nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CampoNombre)
                    .HasColumnName("campo_nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdLlave).HasColumnName("id_llave");

                entity.Property(e => e.Modificado).HasColumnName("modificado");

                entity.Property(e => e.NuevoNombre)
                    .HasColumnName("nuevo_nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TablaNombre)
                    .HasColumnName("tabla_nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasColumnName("usuario")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.ToTable("usuarios");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasMaxLength(2)
                    .IsFixedLength()
                    .HasDefaultValueSql("'AC'");

                entity.Property(e => e.FechaTerminos)
                    .HasColumnName("fecha_terminos")
                    .HasColumnType("date");

                entity.Property(e => e.IdPersona).HasColumnName("id_persona");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Perfil)
                    .IsRequired()
                    .HasColumnName("perfil")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tramites)
                    .HasColumnName("tramites")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ValidacionTitulos>(entity =>
            {
                entity.HasKey(e => e.IdValidacion)
                    .HasName("PRIMARY");

                entity.ToTable("validacion_titulos");

                entity.Property(e => e.IdValidacion).HasColumnName("id_validacion");

                entity.Property(e => e.ArgumentosRecurrente).HasColumnName("argumentos_recurrente");

                entity.Property(e => e.Articulos).HasColumnName("articulos");

                entity.Property(e => e.CausalesNegacion)
                    .HasColumnName("causales_negacion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoVerificacion)
                    .IsRequired()
                    .HasColumnName("codigo_verificacion")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Consideraciones).HasColumnName("consideraciones");

                entity.Property(e => e.Consideraciones2).HasColumnName("consideraciones2");

                entity.Property(e => e.Fecha).HasColumnName("fecha");

                entity.Property(e => e.FechaTermerrada)
                    .HasColumnName("fecha_termerrada")
                    .HasColumnType("date");

                entity.Property(e => e.IdArchivo).HasColumnName("id_archivo");

                entity.Property(e => e.IdEstadoTramite).HasColumnName("id_estado_tramite");

                entity.Property(e => e.IdTitulo).HasColumnName("id_titulo");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.NombreInstitucionerrado)
                    .HasColumnName("nombre_institucionerrado")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NombreProfesionnerrado)
                    .HasColumnName("nombre_profesionnerrado")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NombresapellidosErrados)
                    .HasColumnName("nombresapellidos_errados")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Observacion1aclaracion).HasColumnName("observacion1aclaracion");

                entity.Property(e => e.Observacion2aclaracion).HasColumnName("observacion2aclaracion");

                entity.Property(e => e.Observacion3aclaracion).HasColumnName("observacion3aclaracion");

                entity.Property(e => e.Observaciones).HasColumnName("observaciones");

                entity.Property(e => e.OtrasCausalesNegacion).HasColumnName("otras_causales_negacion");

                entity.Property(e => e.TipoIdentificacionerrada)
                    .HasColumnName("tipo_identificacionerrada")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
