//Homework 1 Executable
using System.Windows.Forms;

class ExecutableMain {
	static void Main(string[] args) {
        //Defulting variables
        string formTitle = "Defult Title";
        string userName = "No Name";

        //Check if proper amount of argument line
        if(args.Length > 1) {
            formTitle = args[0];
            userName = args[1];
        }

		Application.Run(new FirstForm(formTitle, userName));
	}
}