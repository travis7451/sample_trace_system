using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Diagnostics;
using 產品驗證系統.Models;
using DBconnTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace 產品驗證系統.Models
{
    public class HomeModels
    {

    }

    public class Sample_trace
    {
        public string? NO { get; set; }
        public string? p_serial_nu_start { get; set; }
        public string? p_serial_nu_end { get; set; }
        public string? Model { get; set; }
        public string? PN { get; set; }
        public string? Description { get; set; }
        public string? CTL { get; set; }
        public string? FlashPN { get; set; }
        public string? FWversion { get; set; }
        public string? PCB { get; set; }
        public string? QTY { get; set; }
        public string? Capacity { get; set; }
        public string? TCGOpal { get; set; }
        public string? CoreSnapshot { get; set; }
        public string? WP { get; set; }
        public string? fullErase { get; set; }
        public string? Destroy { get; set; }
        public string? Instantkeychange { get; set; }
        public string? NSA9_12 { get; set; }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

    public List<Sample_trace> GetSample_Traces()
    {
        List<Sample_trace> sample_traces = new List<Sample_trace>();
        SqlConnection sqlConnection = new("Data Source=DESKTOP-HK83OLF\\SQLSERVER;Initial Catalog=trace_table;user=sa;password=@Pacer2022;Timeout=180;Min Pool Size =10;Max Pool Size = 100;");
        SqlCommand sqlCommand = new("SELECT * FROM sample_trace")
        {
            Connection = sqlConnection
        };
        sqlConnection.Open();

        SqlDataReader reader = sqlCommand.ExecuteReader();
        if (reader.HasRows)
        {
            while (reader.Read())
            {
                Sample_trace sample_trace = new Sample_trace
                {
                    p_serial_nu_start = reader.GetString(reader.GetOrdinal("p_serial_nu_start")),
                    p_serial_nu_end = reader.GetString(reader.GetOrdinal("p_serial_nu_end")),
                    Model = reader.GetString(reader.GetOrdinal("Model")),
                    PN = reader.GetString(reader.GetOrdinal("PN")),
                };
                sample_traces.Add(sample_trace);
            }
        }
        else
        {
            Console.WriteLine("資料庫為空！");
        }
        sqlConnection.Close();
        return sample_traces;
    }
}
