using Command_Pattern_ex1;

Document document = new Document();
Editor editor = new Editor();

ICommand addHelloCommand = new AddTextCommand(document, "Hello ");
ICommand addWorldCommand = new AddTextCommand(document, "World!");

editor.SetCommand(addHelloCommand);
editor.ExecuteCommand();

editor.SetCommand(addWorldCommand);
editor.ExecuteCommand();

editor.Undo();

editor.Undo();