/**
 * Class to represent a Node in a Binary Search Tree (BST).
 */
class BSTNode {
    /**
     * Constructs a new instance of a BST node.
     * @param {number} data The integer to store in the node.
     */
    constructor(data) {
        this.data = data;
        /**
         * These properties are how this node is connected to other nodes to form
         * the tree. Similar to .next in a SinglyLinkedList except a BST node can
         * be connected to two other nodes. To start, new nodes will not be
         * connected to any other nodes, these properties will be set after
         * the new node is instantiated.
         *
         * @type {BSTNode|null}
         */
        this.left = null;
        /** @type {BSTNode|null} */
        this.right = null;
    }
}

/**
 * Represents an ordered tree of nodes where the data of left nodes are <= to
 * their parent and the data of nodes to the right are > their parent's data.
 */
class BinarySearchTree {
    constructor() {
        /**
         * Just like the head of a linked list, this is the start of our tree which
         * branches downward from here.
         *
         * @type {BSTNode|null}
         */
        this.root = null;
    }

    /**
     * Determines if this tree is empty.
     * - Time: O(?).
     * - Space: O(?).
     * @returns {boolean} Indicates if this tree is empty.
     */
    isEmpty() {
        //Your code here
        return this.root === null;
    }

    /**
     * Retrieves the smallest integer data from this tree or null if tree is empty.
     * - Time: O(?).
     * - Space: O(?).
     * @param {Node} current The node that is currently accessed from the tree as
     *    the tree is being traversed.
     * @returns {number} The smallest integer from this tree.
     */
    min(current = this.root) {
        //Your code here
        if (this.isEmpty()) return null;
        while (current.left) {
            current = current.left;
        }
        return current.data;
    }

    /**
     * Retrieves the smallest integer data from this tree or null if tree is empty.
     * - Time: O(?).
     * - Space: O(?).
     * @param {Node} current The node that is currently accessed from the tree as
     *    the tree is being traversed.
     * @returns {number} The smallest integer from this tree.
     */
    minRecursive(current = this.root) {
        //Your code here
        if (current == null) return null;
        if (current.left == null) return current.data;
        return this.minRecursive(current.left);
    }

    /**
     * Retrieves the largest integer data from this tree or null if tree is empty.
     * - Time: O(?).
     * - Space: O(?).
     * @param {Node} current The node that is currently accessed from the tree as
     *    the tree is being traversed.
     * @returns {number} The largest integer from this tree.
     */
    max(current = this.root) {
        //Your code here
        if (this.isEmpty()) return null;
        while (current.right) {
            current = current.right;
        }
        return current.data;
    }

    /**
     * Retrieves the largest integer data from this tree or null if tree is empty.
     * - Time: O(?).
     * - Space: O(?).
     * @param {Node} current The node that is currently accessed from the tree as
     *    the tree is being traversed.
     * @returns {number} The largest integer from this tree.
     */
    maxRecursive(current = this.root) {
        //Your code here
        if (current == null) return null;
        if (current.right == null) return current.data;
        return this.maxRecursive(current.right);
    }

    // Logs this tree horizontally with the root on the left.
    print(node = this.root, spaceCnt = 0, spaceIncr = 10) {
        if (!node) {
            return;
        }

        spaceCnt += spaceIncr;
        this.print(node.right, spaceCnt);

        console.log(
            " ".repeat(spaceCnt < spaceIncr ? 0 : spaceCnt - spaceIncr) +
            `${node.data}`
        );

        this.print(node.left, spaceCnt);
    }

    /**
     * Determines if this tree contains the given searchVal.
     * - Time: O(?).
     * - Space: O(?).
     * @param {number} searchVal The number to search for in the node's data.
     * @returns {boolean} Indicates if the searchVal was found.
     */
    contains(searchVal) {
        if (this.isEmpty()) return false;
        let current = this.root;
        while (current) {
            if (current.data === searchVal) return true;
            if (searchVal < current.data) {
                current = current.left;
            } else {
                current = current.right;
            }
        }
        return false;
    }

    /**
     * Determines if this tree contains the given searchVal.
     * - Time: O(?).
     * - Space: O(?).
     * @param {number} searchVal The number to search for in the node's data.
     * @returns {boolean} Indicates if the searchVal was found.
     */
    containsRecursive(searchVal, current = this.root) {
        if (current === null) return false;
        if (current.data === searchVal) return true;
        if (searchVal < current.data) return this.containsRecursive(searchVal, current.left);
        return this.containsRecursive(searchVal, current.right);
    }

    /**
     * Calculates the range (max - min) from the given startNode.
     * - Time: O(?).
     * - Space: O(?).
     * @param {Node} startNode The node to start from to calculate the range.
     * @returns {number|null} The range of this tree or a sub tree depending on if the
     *    startNode is the root or not.
     */
    range(startNode = this.root) {
        if (startNode == null) return null;
        return this.max(startNode) - this.min(startNode);
    }

    // https://www.cs.usfca.edu/~galles/visualization/BST.html
    /**
     * Inserts a new node with the given newVal in the right place to preserve
     * the order of this tree.
     * - Time: O(?).
     * - Space: O(?).
     * @param {number} newVal The data to be added to a new node.
     * @returns {BinarySearchTree} This tree.
     */
    insert(newVal) {
        const node = new BSTNode(newVal);

        //if empty, make the new root
        if (this.isEmpty()) {
            this.root = node;
            return this;
        }

        let current = this.root;

        while (true) {
            if (newVal >= current.data) { // if greater or equal, go right
                if (current.right === null) { // if there is no right, insert here
                    current.right = node;
                    return this;
                }

                current = current.right;
            } else {
                // newVal is less than current.data
                if (current.left === null) { // if there is no left, insert here
                    current.left = node;
                    return this;
                }

                current = current.left;
            }
        }
    }

    /**
     * Inserts a new node with the given newVal in the right place to preserve
     * the order of this tree.
     * - Time: O(?).
     * - Space: O(?).
     * @param {number} newVal The data to be added to a new node.
     * @param {Node} curr The node that is currently accessed from the tree as
     *    the tree is being traversed.
     * @returns {BinarySearchTree} This tree.
     */
    insertRecursive(newVal, curr = this.root) {
        if (this.isEmpty()) {
            this.root = new BSTNode(newVal);
            return this;
        }

        if (newVal >= curr.data) {
            if (curr.right === null) {
                curr.right = new BSTNode(newVal);
                return this;
            }
            return this.insertRecursive(newVal, curr.right);
        }

        if (curr.left === null) {
            curr.left = new BSTNode(newVal);
            return this;
        }
        return this.insertRecursive(newVal, curr.left);
    }

    /**
     * DFS Inorder: (Left, CurrNode, Right)
     * Converts this BST into an array following Depth First Search inorder.
     * See debugger call stack to help understand the recursion.
     * Example on the fullTree var:
     * [4, 10, 12, 15, 18, 22, 24, 25, 31, 35, 44, 50, 66, 70, 90]
     * @param {Node} node The current node during the traversal of this tree.
     * @param {Array<number>} vals The data that has been visited so far.
     * @returns {Array<number>} The vals in DFS Preorder once all nodes visited.
     */
    toArrInorder(node = this.root, vals = []) {
        //Your code here
        if (node) {
            this.toArrInorder(node.left, vals);
            vals.push(node.data);
            this.toArrInorder(node.right, vals);
        }
        return vals;
    }

    /**
     * DFS Preorder: (CurrNode, Left, Right)
     * Converts this BST into an array following Depth First Search preorder.
     * Example on the fullTree var:
     * [25, 15, 10, 4, 12, 22, 18, 24, 50, 35, 31, 44, 70, 66, 90]
     * @param {Node} node The current node during the traversal of this tree.
     * @param {Array<number>} vals The data that has been visited so far.
     * @returns {Array<number>} The vals in DFS Preorder once all nodes visited.
     */
    toArrPreorder(node = this.root, vals = []) {
        //Your code here
        if (node) {
            vals.push(node.data);
            this.toArrPreorder(node.left, vals);
            this.toArrPreorder(node.right, vals);
        }
        return vals;
    }


    /**
     * DFS Postorder (Left, Right, CurrNode)
     * Converts this BST into an array following Depth First Search postorder.
     * Example on the fullTree var:
     * [4, 12, 10, 18, 24, 22, 15, 31, 44, 35, 66, 90, 70, 50, 25]
     * @param {Node} node The current node during the traversal of this tree.
     * @param {Array<number>} vals The data that has been visited so far.
     * @returns {Array<number>} The vals in DFS Preorder once all nodes visited.
     */
    toArrPostorder(node = this.root, vals = []) {
        // Your code here 
        if (node) {
            this.toArrPostorder(node.left, vals);
            this.toArrPostorder(node.right, vals);
            vals.push(node.data);
        }
        return vals;
    }

    /**
         * BFS order: horizontal rows top-down left-to-right.
         * Converts this BST into an array following Breadth First Search order.
         * Example on the fullTree var:
         * [25, 15, 50, 10, 22, 35, 70, 4, 12, 18, 24, 31, 44, 66, 90]
         * @param {Node} current The current node during the traversal of this tree.
         * @returns {Array<number>} The data of all nodes in BFS order.
    */
    toArrLevelorder(current = this.root) {
        const queue = [];
        const vals = [];

        if(current){
            queue.push(current);
        }

        while (queue.length > 0){
            current = queue.shift();
            vals.push(current.data);
            if (current.left){
                queue.push(current.left);
            }
            if (current.right){
                queue.push(current.right);
            }
        }

        return vals;
    }


}


const fullTree = new BinarySearchTree();
fullTree
    .insert(25)
    .insert(15)
    .insert(10)
    .insert(22)
    .insert(4)
    .insert(12)
    .insert(18)
    .insert(24)
    .insert(50)
    .insert(35)
    .insert(70)
    .insert(31)
    .insert(44)
    .insert(66)
    .insert(90);

/* fullTree
                root
            <-- 25 -->
          /            \
        15             50
      /    \         /    \
    10     22      35     70
  /   \   /  \    /  \   /  \
4    12  18  24  31  44 66  90

*/

console.log(fullTree.toArrLevelorder(), "\nshould be \n [25, 15, 50, 10, 22, 35, 70, 4, 12, 18, 24, 31, 44, 66, 90]"); 