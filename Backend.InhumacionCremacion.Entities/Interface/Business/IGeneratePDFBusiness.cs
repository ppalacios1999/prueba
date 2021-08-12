using Backend.InhumacionCremacion.Entities.Responses;
using System.Threading.Tasks;

namespace Backend.InhumacionCremacion.Entities.Interface.Business
{
    /// <summary>
    /// IGeneratePDF
    /// </summary>
    public interface IGeneratePDFBusiness
    {
        /// <summary>
        /// Generates the PDF.
        /// </summary>
        /// <returns></returns>
        Task<ResponseBase<dynamic>> GeneratePDF();
    }
}
