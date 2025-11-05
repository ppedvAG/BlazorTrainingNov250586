namespace BlazorTrainingNov250586.Components.Pages.Modul4
{
    public class ChatVM
    {
        public List<ChatModel> Liste { get; set; } = new();
        public event Action OnAdd;
        public void AddMessage(string msg)
        {
            Liste.Add(new ChatModel() { Message = msg });
            OnAdd?.Invoke();
        }
    }
}
