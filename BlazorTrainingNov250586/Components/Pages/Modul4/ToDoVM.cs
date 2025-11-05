namespace BlazorTrainingNov250586.Components.Pages.Modul4
{
    public class ToDoVM
    {
        public List<Todo> ToDoList { get; set; } = new List<Todo>();
        public ToDoVM(IHttpClientFactory _http)
        {
            var client = _http.CreateClient();
            var response = client.GetFromJsonAsync<ToDos>("https://dummyjson.com/todos?limit=300").Result;
            ToDoList = response.todos.ToList();

        }
    }
}
