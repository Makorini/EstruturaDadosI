using Trees;

tree<int> tree = new tree<int>();
//inicializa o no rais com o calor 1000
tree.Root = new TreeNode<int>() { 
   Data = 1000
    };
//troca ovalor de data no nó rais
tree.Root.data = 100;
//informa carga de nos filhos
tree.Root.Children = new List<TreeNode<int>> //nos filhos
{
    new TreeNode<int>() { 
        Data = 50,
        Parent = tree
        },
        new TreeNode<int>() { 
        Data = 5,
        Parent = tree
        }
};
//adicionando no em tempo de execução
TreeNode<int> filho3 = new TreeNode<int>(); //duas formas de declaracao dos filhos
filho3.Data = 0;
filho3.Parent = tree.Root;
tree.Root.Children.Add(filho3);

//adicionando  netos de root , ou seja,
//filhos do primeiro nivel de hereditariedade 

tree.Root.Children[0].Children = new List<TreeNode<int>>
{
    new TreeNode<int>() { 
        Data = 50,
        Parent = tree.Root
        }
};
//adicionando netos  de root  no segundo filho
TreeNode<int> neto2 = new TreeNode<int>();
Neto2.Data = 200;
Neto2.Parent = tree.Root.Children[1];

tree.Root.Children[1].Childre = new List<TreeNode<int>();
tree.Root.Childre.Add(Neto2);

int level = tree.Root.GetHeight();
string message = $"esta arvore Contém {level} nevel";
Console.WriteLine(massage);