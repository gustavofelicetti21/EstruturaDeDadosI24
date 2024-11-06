using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeArvoreBasica
{
    public class Tree<T>
    {
        public Node<T>? Root { get; set; }

        public void PrintTree(Node<T> node)
        {
            Console.WriteLine($"Level: {nod}");
            Console.WriteLine($"Node: {node.Data}\n");

            if(node.Children!.Count > 0) 
            {
                foreach(var i in node.Children!)
                {
                    PrintTree(i);
                }
            }
        }
    }
}