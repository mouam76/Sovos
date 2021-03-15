using DataAccess.DataAccess;
using DataAccess.Models;
using System.Collections.Generic;

namespace DataAccess.Logic
{
    public static class CaseProcessor
    {
        public static List<CaseModel> LoadCases()
        {
            string sql = @"SELECT * FROM DBO.DASHBOARD;";

            return SQLDataAccess.LoadData<CaseModel>(sql);
        }
    }
}
