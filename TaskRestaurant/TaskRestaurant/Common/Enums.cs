
namespace TaskRestaurant.Common
{
    // to detect current user order status 
    // ( we can add any status for our project cases )
    public enum OrderStatus : int
    {
        Waiting = 0,
        Done = 1,
        Unknown = 2
    }
}
