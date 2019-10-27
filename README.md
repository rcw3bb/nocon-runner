# NoCon-Runner (No Console Runner)

A simple tool to run a command without showing the console window.

## Creating a Windows Shortcut

Use the following syntax in creating a windows shortcut.

Syntax:

```
nocon-runner <COMMAND> [<ARG1>[ <ARG2>[ <ARGN>]
```

1. Using the **windows explorer**, navigate to the folder where the **target command** lives.

2. Place the **nocon-runner.exe** in the same folder.

3. **Right click** within the folder and select the **New menu** and then **Shortcut menu**.

4. **Browse** until you can select the **nocon-runner.exe** you've placed from step 2. 

5. After the **nocon-runner.exe**, type in the **command** *(i.e. complying with the syntax above)* you wanted to execute *(i.e. normally it opens a console window before running)*.

6. Click the **next button**.

7. **Type in** the command you've used from step 5.

8. Click the **finish button**.

   > Now, when you double click the newly created shortcut, it will run the command you specified from step 5 without opening the console window.

## Using a Configuration File

If you don't want to create a shortcut, you can create a configuration file the contains the command and it optional arguments.

1. Using the **windows explorer**, navigate to the folder where the **target command** lives.

2. Place the **nocon-runner.exe** *(and rename it if you like)* in the same folder.

3. Create a **new folder** named **conf**.

4. Inside the conf folder, create a **nocon.json** file.

	###### The nocon.json has the following format:

   ```json
   {
       "Command" : "<COMMAND>"
       ,"Arguments" : ["<ARG1>", "<ARG2>", "<ARGN>"]
   }
   ```

   *Note: **You can remove the Arguments line in the nocon.json file** if the command doesn't requires any argument.*

5. **Save the nocon.json file** after updating it.

   > Now, when you double click the nocon-runner.exe, it will run the command you specified from the nocon.json file without opening the console.

## Author

* Ronaldo Webb

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## [Build](BUILD.md)

## [Changelog](CHANGELOG.md)

