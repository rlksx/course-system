using course_system.SharedContext;
namespace course_system.SubscriptionContext
{
    public class Subscription : Base
    {
        public Plan Plan { get; set; } // plano da assinatura;
        public DateTime? EndDate { get; set; } // date que encerra a assinatura;

        // se a data está menor que a data atual o plano esta inativo;
        public bool IsInativite => EndDate <= DateTime.Now;
    }
} 