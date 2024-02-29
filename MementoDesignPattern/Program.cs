

using MementoDesignPattern;

TextEditorHistory history = new TextEditorHistory();
//le creattion d'objet de type TextEditor avec une valeur initial
Console.WriteLine("-----------------modification-----------------");
TextEditor textEditor = new TextEditor("Initial Content");
Console.WriteLine(textEditor.Content);

// sauvegarder la valeur
history.Push(textEditor.CreateMemento());

//modifier la valeur initial
textEditor.Content = "something new 1";
Console.WriteLine(textEditor.Content);
//Sauvegarde
history.Push(textEditor.CreateMemento());


textEditor.Content = "something new 2";
Console.WriteLine(textEditor.Content);
history.Push(textEditor.CreateMemento());


//restorer les valeurs precedentes
Console.WriteLine("-----------------restoration-----------------");


textEditor.RestoreMemento(history.Restore());
Console.WriteLine(textEditor.Content);

textEditor.RestoreMemento(history.Restore());
Console.WriteLine(textEditor.Content);

textEditor.RestoreMemento(history.Restore());
Console.WriteLine(textEditor.Content);






Console.ReadKey();
