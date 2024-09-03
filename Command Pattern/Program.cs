using Command_Pattern;

ICommand printHelloCommand = new PrintCommand("Hello, World!");
ICommand connectCommand = new ConnectDeviceCommand();
ICommand disconnectCommand = new DisconnectDeviceCommand();

// Create invoker
RemoteControl remote = new RemoteControl();

// Use the invoker to execute commands
remote.SetCommand(printHelloCommand);
remote.PressButton();

remote.SetCommand(connectCommand);
remote.PressButton();

remote.SetCommand(disconnectCommand);
remote.PressButton();