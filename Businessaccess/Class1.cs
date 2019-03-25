namespace DisconnectedAssgmnet
{
    public class Class1
    {
        Dataacess dal = new Dataacess();

        public void InsertAddress(Address address)
        {
            dal.InsertAddress(address);
        }
        public void DeleteAddress(int Address_id)
        {
            dal.DeleteAddress(Address_id);
        }
        public Address SearchAdress(string Address_id)
        {
            return dal.SearchAdress(Address_id);
        }
        public void UpdateAddress(int Address_id, Address address)
        {
            dal.UpdateAddress(Address_id, address);
        }
    }
}
