namespace BinarySearchTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Add(65);
            tree.Add(80);
            tree.Add(30);
            tree.Add(40);
            tree.Add(61);
            tree.Add(22);
            tree.Add(97);
            tree.Add(56);
            tree.Add(14);
            tree.Add(2);
            tree.Add(57);
            tree.Add(66);
            tree.Add(11);
            int data = 61;
            Node<int> node = tree.Find(data, tree.Root);
            if (node == null)
            {
                Console.WriteLine($"{data} is not present in Binary Tree");
            }
            else
            {
                Console.WriteLine($"{node.Data} is Present in Binaray Tree");
            }
            Console.WriteLine("******** Elements in Binary Trees **********");
            tree.DisplayInorder(tree.Root);
            Console.WriteLine();
            tree.Size();


        }
    }
}