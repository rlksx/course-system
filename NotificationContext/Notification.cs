namespace course_system.NotificationContext
{
    // classe impedida de gerar subclasses; 
    public sealed class Notification 
    {
        // propriedade que causou o erro;
        public string  Property { get; set; }
        // mensagem do erro;
        public string Message { get; set; }

        // construtor sem nada, caso necessite;
        public Notification() {   }

        // construtor principal;
        public Notification(string property, string message)
        {
            this.Property = property;
            this.Message = message; 
        }
    }
}