namespace Models
{
    public class Order
    {
        int orderNumber;
        string curUser;
        string orderDesc;

        public Order(int oNum, string user, string desc)
        {
            this.orderNumber = oNum;
            this.curUser = user;
            this.orderDesc = desc;
        }

        public int getOrderNumber() {return this.orderNumber;}
        public string getCurUser() {return this.curUser;}
        public string getOrderDesc() {return this.orderDesc;}
    }
}