public interface GameService
{
    void openMenu();

    void openAskMenu();

    void StartNewGame();

    void SaveRecord(string value);

    string ShowRecord();
}