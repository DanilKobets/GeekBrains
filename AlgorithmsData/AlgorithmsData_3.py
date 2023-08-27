class Node:

 def __init__(self, data, next=None):
   self.data = data
   self.next = next

 def __str__(self):
   return f'{self.data=} {self.next=}'


class LinkedList:

 def __init__(self, head=None):
    self.head = head

 def add_node(self, data):
    self.head = Node(data, self.head)
 # self.head = node

 def print_lst(self):
      current = self.head
      while current:
         print(current)
      current = current.next


lst = LinkedList()

lst.add_node('1')
lst.add_node('2')
lst.add_node('3')
lst.add_node('4')

lst.print_lst()
################################
class Node {
    int val;
    Node next;

    public Node(int val) {
        this.val = val;
    }
}

class Answer {
    Node head;

    public void reverse() {
        if (head == null || head.next == null) {
            return; // если список пуст или содержит только один элемент, нет необходимости разворачивать
        }

        Node previous = null;
        Node current = head;
        Node next;

        while (current != null) {
            next = current.next; // сохраняем следующий элемент

            current.next = previous; // меняем указатель на следующий элемент на предыдущий

            previous = current; // обновляем предыдущий элемент
            current = next; // переходим к следующему элементу
        }

        head = previous; // обновляем голову списка
    }
}

public class Printer {
    public static void main(String[] args) {
        // Создаем связанный список 1 -> 2 -> 3 -> 4
        Node head;
        if (args.length == 0) {
            head = new Node(1);
            head.next = new Node(2);
            head.next.next = new Node(3);
            head.next.next.next = new Node(4);
        } else {
            head = new Node(Integer.parseInt(args[0]));
            head.next = new Node(Integer.parseInt(args[1]));
            head.next.next = new Node(Integer.parseInt(args[2]));
            head.next.next.next = new Node(Integer.parseInt(args[3]));
        }

        // Сохраняем голову списка в поле класса Answer
        Answer ans = new Answer();
        ans.head = head;
        // Инвертируем порядок элементов списка
        ans.reverse();

        // Выводим инвертированный порядок элементов списка
        Node current = ans.head;
        while (current != null) {
            System.out.print(current.val + " ");
            current = current.next;
        }
    }
}
################################GPT

# 1. В методе `search`, добавим базовый случай, чтобы если `node` равен `None`, возвратить кортеж `(None, parent)`.
# 2. В методе `insert`, перед добавлением нового узла, убедимся, что `res[0]` не равен `None`, чтобы избежать ошибки при проверке `res[0].value` в строке 174.

# Вот обновленный код:

class Node:
    def __init__(self, value, left=None, right=None):
        """
        Конструктор класса Node.

        Args:
            value: Значение узла.
            left: Левый потомок узла (по умолчанию None).
            right: Правый потомок узла (по умолчанию None).
        """
        self.value = value
        self.left = left
        self.right = right

    def __str__(self):
        """
        Возвращает строковое представление узла.

        Returns:
            Строковое представление узла.
        """
        res = f'Значение узла: {self.value}'
        if self.left:
            res += f', Левый узел: {self.left.value}'
        if self.right:
            res += f', Правый узел: {self.right.value}'
        return res


class BinaryTree:
    def __init__(self):
        """
        Конструктор класса BinaryTree.
        """
        self.root = None

    def search(self, value, node=None, parent=None):
        """
        Поиск узла с заданным значением в дереве.

        Args:
            value: Значение для поиска.
            node: Текущий узел (по умолчанию корень дерева).
            parent: Родительский узел (по умолчанию None).

        Returns:
            Кортеж, содержащий найденный узел и его родителя (если найден).
            Если узел не найден, возвращает (None, None).
        """
        if node is None:
            return None, None

        if value == node.value:
            return node, parent

        if value < node.value:
            return self.search(value, node.left, node)
        else:
            return self.search(value, node.right, node)

    def insert(self, value):
        """
        Вставка нового значения в дерево.

        Args:
            value: Значение для вставки.
        """
        if self.root is None:
            self.root = Node(value)
        else:
            res = self.search(value)
            if res[1] is None:
                new_node = Node(value)
                if value < res[1].value:
                    res[1].left = new_node
                else:
                    res[1].right = new_node
            else:
                print('Такое значение уже существует в дереве')

    def delete(self, value):
        """
        Удаление значения из дерева.

        Args:
            value: Значение для удаления.
        """
        res = self.search(value)
        node = res[0]
        parent = res[1]

        if node is None:
            return

        if node.left is None and node.right is None:
            # Узел является листом
            if parent is None:
                self.root = None
            elif value < parent.value:
                parent.left = None
            else:
                parent.right = None
        elif node.left is not None and node.right is not None:
            # У узла есть оба потомка
            successor = node.right
            while successor.left is not None:
                successor = successor.left
            node.value = successor.value
            self.delete(successor.value)
        else:
            # У узла есть только один потомок
            child = node.left if node.left is not None else node.right
            if parent is None:
                self.root = child
            elif value < parent.value:
                parent.left = child
            else:
                parent.right = child

    def count_elements(self, node=None):
        """
        Подсчет количества элементов в дереве.

        Args:
            node: Текущий узел (по умолчанию корень дерева).

        Returns:
            Количество элементов в дереве.
        """
        if node is None:
            node = self.root

        if node is None:
            return 0

        return 1 + self.count_elements(node.left) + self.count_elements(node.right)


# Пример использования
tree = BinaryTree()
tree.insert(10)
tree.insert(23)
tree.insert(30)
tree.insert(15)
tree.insert(25)
tree.insert(35)

print(tree.count_elements())
tree.delete(20)
print(tree.count_elements())
print(tree.search(25)[0])
            
##################################

class Node:
    def __init__(self, value, left=None, right=None):
        self.value = value
        self.left = left
        self.right = right

    def __str__(self):
        res = f'Значение узла: {self.value}'
        if self.left:
            res += f', Левый узел: {self.left.value}'
        if self.right:
            res += f', Правый узел: {self.right.value}'
        return res


class Tree:
    def __init__(self, root=None):
        self.root = root

    def search(self, node, data, parent=None):
        if node is None or data == node.value:
            return node, parent
        if data > node.value:
            return self.search(node.right, data, node)
        if data < node.value:
            return self.search(node.left, data, node)

    def add_node(self, value):
        res = self.search(self.root, value)
        if not res[0]:
            new_node = Node(value)
            if value > res[0].value:
                res[0].right = new_node
            else:
                res[0].left = new_node
        else:
            print('Такое значение уже существует в дереве')

    def print_tree(self, node):
        if node is not None:
            self.print_tree(node.left)
            print(node)
            self.print_tree(node.right)


# Пример использования
initial_node = Node(15)
tree_1 = Tree(initial_node)

print(initial_node)
# tree_1.add_node(16)
print(initial_node.right)
print(initial_node)
print(tree_1.search(initial_node, 16))
tree_1.print_tree(initial_node)

################################


# создание нодов, создание бинарного дерева, добавление значения, удаление значения, подсчет количества элементов.

class Node:
   def __init__(self, value, left = None, right = None):
      self.value = value
      self.left = left
      self.right = right

   def __str__(self):
      res = f'значение нашего узла: {self.value}'
      # if self.left and self.right:
      # res = f'значение нашего узла: {self.value}, значения левого: {self.left.value}, значение правого: {self.right.value}'
      if self.left:
         res += f' значение левого: {self.left.value}'
      if self.right:
         res += f' значение правого: {self.right.value}'
      return res

class Tree:
   def __init__(self, root = None):
      self.root = root

def search(self, node, data, parent = None):
   if node == None or data == node.value:              
      return node, parent        
   if data > node.value:             
      return self.search(node.right, data, node)
   if data < node.value:            
      return self.search(node.left, data, node)

def add_node(self, value):
    res = self.search(self.root, value)
    if not res[2]:
        new_node = Node(value)
        if value > res[0].value:
            res[0].right = new_node
        else:
            res[0].left = new_node
    else:
        print('Ой все, такое значение уже есть')

def print_tree(self):
# initial_node = Node(15)

tree_1 = Tree(initial_node)

print(initial_node)
tree_1.add_node(16)
print(initial_node.right)
print(initial_node)
print(tree_1.search(initial_node, 16))




