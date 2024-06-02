using namespace std;

class BinaryTree {
 public:
  int value;
  BinaryTree* left;
  BinaryTree* right;

  BinaryTree(int value) {
    this->value = value;
    left = nullptr;
    right = nullptr;
  }
};

void recursive(BinaryTree* root, int currentsum, vector<int> &sums)
{
  if(root->left!=nullptr)
    recursive(root->left, currentsum+root->value, sums);
  if(root->right!=nullptr)
    recursive(root->right, currentsum+root->value, sums);
  if(root->right==nullptr && root->left==nullptr)
    sums.push_back(currentsum+root->value);
}

vector<int> branchSums(BinaryTree* root) {
  vector<int> sums;
  recursive(root, 0, sums);
  return sums;
}
