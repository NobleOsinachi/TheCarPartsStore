namespace StoreModels
{
    /// <summary>
    /// This class should contain all the fields and properties that define a customer order. 
    /// </summary>
    public class Order
    {
        public Customer Customer { get;  set; }
        public Location Location { get; set; }
        public double Total { get; set; }

        //TODO: add a property for the order items

        public Item Item {get;set;}
        public int? Id { get; set; }

        public override string ToString() =>  $"{this.Customer.ToString()}";// $"\n\t location name: {this.Location.ToString()} \n\t Item name: {this.Item.ToString()} \n\t Total: {this.Total}";
    }
}