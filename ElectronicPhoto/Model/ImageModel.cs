using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlServerCe;
using ElectronicPhoto.Utility;

namespace ElectronicPhoto.Model
{
    class ImageModel
    {
        private int _id;

        public int Id
        {
            private set
            {
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }

        private string _path;

        public string Path
        {
            set
            {
                this._path = value;
            }

            get
            {
                return this._path;
            }
        }

        private string _caption;

        public string Caption
        {
            set
            {
                this._caption = value;
            }
            get
            {
                return this._caption;
            }
        }

        private string _comment;

        public string Comment
        {
            set
            {
                this._comment = value;
            }
            get
            {
                return this._comment;
            }
        }

        private DateTime _date;

        public DateTime Date
        {
            set
            {
                this._date = value;

            }

            get
            {
                return this._date;
            }
        }

        public ImageModel() {}

        public ImageModel(object id, object path, object caption, object comment, object date)
        {
            this.Id      = Convert.ToInt16(id);
            this.Path    = Convert.ToString(path);
            this.Caption = Convert.ToString(caption);
            this.Comment = Convert.ToString(comment);
            this.Date    = Convert.ToDateTime(date);
        }

        public void Upload()
        {
            using (SqlCeConnection connection = new SqlCeConnection(CommonVariables.ConnectionString))
            {
                connection.Open();
                
                string sql       = "INSERT INTO images(path,caption,comment,date) VALUES(@param1,@param2,@param3,@param4)";
                SqlCeCommand cmd = new SqlCeCommand(sql, connection);
                cmd.Parameters.Add("@param1", SqlDbType.NVarChar, 255).Value = this.Path;
                cmd.Parameters.Add("@param2", SqlDbType.NVarChar, 255).Value = this.Caption;
                cmd.Parameters.Add("@param3", SqlDbType.NVarChar, 350).Value = this.Comment;
                cmd.Parameters.Add("@param4", SqlDbType.DateTime, 8).Value   = this.Date;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                connection.Close();
            }
        }

        public static List<ImageModel> GetAll()
        {
            using (SqlCeConnection connection = new SqlCeConnection(CommonVariables.ConnectionString))
            {
                connection.Open();

                string sql       = "SELECT * FROM images";
                SqlCeCommand cmd = new SqlCeCommand(sql, connection);
                cmd.CommandType  = CommandType.Text;

                SqlCeDataReader reader = cmd.ExecuteReader();

                List<ImageModel> result = new List<ImageModel>();

                while (reader.Read())
                {
                    result.Add(new ImageModel(reader["id"], reader["path"], reader["caption"], reader["comment"], reader["date"]));
                }

                connection.Close();

                return result;
            }
        }
    }
}
