using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DisconnectedAssgmnet
{
    public class Dataacess
    {
        SqlConnection con;
        SqlDataAdapter sda;
        DataSet ds = new DataSet();
        SqlCommandBuilder sb;
        SqlConnection getConnection()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["Connectionstring1"].ToString());
            return con;
        }

        void fill_dataset()
        {
            con = getConnection();

            sda = new SqlDataAdapter("select * from tbl_Address", con);
            sb = new SqlCommandBuilder(sda);
            sda.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            sda.Fill(ds);

        }
        public void InsertAddress(Address address)
        {
            fill_dataset();
            DataRow dr = ds.Tables[0].NewRow();
            dr["Email"] = address.Email;
            dr["first_name"] = address.First_name;
            dr["last_name"] = address.Last_name;
            dr["Phonenumber"] = address.Phonenumber;
            dr["age"] = address.age;
            ds.Tables[0].Rows.Add(dr);
            sb = new SqlCommandBuilder(sda);
            sda.Update(ds);

        }
        public void DeleteAddress(int Address_id)
        {
            fill_dataset();
            DataRow dr1 = ds.Tables[0].Rows.Find(Convert.ToInt16(Address_id));
            ds.Tables[0].Rows.Find(Convert.ToInt16(Address_id)).Delete();
            sb = new SqlCommandBuilder(sda);
            sda.Update(ds);
        }
        public Address SearchAdress(string Address_id)
        {
            fill_dataset();
            DataRow dr = ds.Tables[0].Rows.Find(Address_id);
            Address address = new Address();
            address.First_name = Convert.ToString(dr["First_name"]);
            address.Last_name = Convert.ToString(dr["Last_name"]);
            address.age = Convert.ToInt32(dr["age"]);
            return address;
        }
        public void UpdateAddress(int Address_id, Address address)
        {
            fill_dataset();
            DataRow dr = ds.Tables[0].Rows.Find(Convert.ToString(Address_id));
            address.First_name = Convert.ToString(dr["First_name"]);
            address.Last_name = Convert.ToString(dr["Last_name"]);
            address.Email = Convert.ToString(dr["Email"]);
            address.Phonenumber = Convert.ToString(dr["Phonenumber"]);
            address.age = Convert.ToInt32(dr["age"]);
            sb = new SqlCommandBuilder(sda);
            sda.Update(ds);
        }
    }
}
