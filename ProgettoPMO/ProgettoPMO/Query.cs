using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoPMO
{
    public class Query // classe che costruisce le query
    {
        private string _table;
        private string _sql;
        private string[] _cols;

        public string Sql
        {
            get { return this._sql; }
        }

        public Query Table(string table)
        {
            this._table = table;
            this._sql = string.Empty;
            this._sql = this.Select("*").Sql;
            return this;
        }

        public Query Select(params string[] cols)
        {
            this._cols = cols;
            this._sql = string.Concat(new string[]{
                "select ",
                string.Join(",", this._cols),
                " from ",
                this._table
            });

            return this;
        }

        public Query Where(string col, object val)
        {
            this._sql = this.Where(col, "=", val).Sql;
            return this;
        }

        public Query Where(string col, string options, object val)
        {
            this._sql += string.Concat(new string[]
            {
                " Where ",
                col,
                " ",
                options,
                " ",
                val.ToString()
            });
            return this;
        }

        public Query OrWhere(string col, string options, object val)
        {
            this._sql += string.Concat(new string[]
            {
                " Or ",
                col,
                " ",
                options,
                " ",
                val.ToString()
            });
            return this;
        }
        public Query AndWhere(string col, string options, object val)
        {
            this._sql += string.Concat(new string[]
            {
                " And ",
                col,
                " ",
                options,
                " ",
                val.ToString()
            });
            return this;
        }
        public Query OrWhere(string col, object val)
        {
            this._sql = this.OrWhere(col, "=", val).Sql;
            return this;
        }

        public Query AndWhere(string col, object val)
        {
            this._sql = this.AndWhere(col, "=", val).Sql;
            return this;
        }
    }
}
