using System;
using SpreadsheetLight; //descargar este Nuget
namespace CrearExcel
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathfile = AppDomain.CurrentDomain.BaseDirectory + "Excel.xlsx"; //el nombre de mi archivo
            SLDocument oSLDocument = new SLDocument();  //Objeto de la libreria
            System.Data.DataTable dt = new System.Data.DataTable(); //objeto de la clase DataTable


            //Columnas
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Identidad", typeof(decimal));
            dt.Columns.Add("Correo", typeof(string));
            dt.Columns.Add("Telefono", typeof(decimal));
            dt.Columns.Add("Edad", typeof(int));


            //rows-Filas llenar datos

            dt.Rows.Add("Zinedine", 1234567890, "Zinedine9301@gmail.com", 30554568880,20);
            dt.Rows.Add("Austin", 12367890, "Austin1@gmail.com", 388123440,22);
            dt.Rows.Add("Elizabeth", 1567890, "Elizabeth01@gmail.com", 3054543880,16);
            dt.Rows.Add("Victoria", 4567890, "Victoria@gmail.com", 3058256680,24);

            oSLDocument.ImportDataTable(1,1,dt,true);

            oSLDocument.SaveAs(pathfile);
        }
    }
}
