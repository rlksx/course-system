using course_system.NotificationContext;
using course_system.SharedContext;
namespace course_system.SubscriptionContext
{
    public class Student : Base
    {
        public User user { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }

        public IList<Subscription> Subscriptions { get; set; } 

        // verificando se há plano ativo
        public bool IsPremium => Subscriptions.Any(x => !x.IsInativite);

        public Student() => Subscriptions = new List<Subscription>();

        public void CreateSubscription(Subscription subscription)
        {
            if (IsPremium)
            {
                AddNotification(new Notification("Premium", "O aluno já tem uma assinatura ativa") );
                return;
            }
            Subscriptions.Add(subscription);
        }
    }
}  