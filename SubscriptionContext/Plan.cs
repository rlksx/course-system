using course_system.SharedContext;
namespace course_system.SubscriptionContext
{
    public class Plan : Base
    {
        public string Title { get; set; }  // titulo/nome do plano;
        public decimal Price { get; set; }  // preço do plano;
        public DateTime? EndTime { get; set; }
    }
}  