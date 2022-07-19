using System.Data;
using System.Data.SqlClient;

namespace 產品驗證系統.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

}