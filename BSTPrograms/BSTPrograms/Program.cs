// See https://aka.ms/new-console-template for more information
BSTPrograms.BinarySearchTree<int> function = new BSTPrograms.BinarySearchTree<int>(56);
function.Insert(30);
function.Insert(70);
function.Insert(3);
function.Insert(11);
function.Insert(16);
function.Insert(67);
function.Insert(63);
function.Insert(65);
function.Insert(60);
function.Insert(95);
function.Insert(40);
function.Insert(22);
function.Display();
function.GetSize();
bool result = function.IfExists(63, function);
Console.WriteLine(result);