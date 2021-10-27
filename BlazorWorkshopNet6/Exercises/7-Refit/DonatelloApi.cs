using Refit;

namespace BlazorUIWorkshop.Exercises._7_Refit;

public interface IDonatelloApi
{
    [Get("/board")]
    Task<IEnumerable<Board>> GetBoards();

    [Get("/board/{id}")]
    Task<IEnumerable<Board>> GetBoard(int id);

    [Post("/board")]
    Task CreateBoard(CreateBoardCommand command);
}

public class CreateBoardCommand
{
    public string Name { get; set; }
}

public class Board
{
    public string Name { get; set; }
    public int Id { get; set; }
}