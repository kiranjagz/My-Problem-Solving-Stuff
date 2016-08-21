using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TestApp.BinarySearchTree;
using static TestApp.CalculateTree;

namespace TestApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region frogtest
            //var frogTest = FrogSteps.RecursiveFrogSteps(3);
            //Console.WriteLine(frogTest.ToString());
            #endregion

            #region anagramtest
            //var isAnagram = Anagrams.AreStringsAnagrams("momdad", "dadmom");
            //Console.WriteLine(isAnagram.ToString());
            #endregion

            #region longestruntest
            //var run = LongestRunIndex.IndexOfLongestRun("aabcddddees");
            //Console.WriteLine(run.ToString());
            #endregion

            #region namescounttest
            //NamesCount namesCount = new NamesCount();
            //namesCount.AddName("John");
            //namesCount.AddName("Mary");
            //namesCount.AddName("Mary");
            //namesCount.AddName("Mary");

            //Console.WriteLine("Fraction of Johns: {0}", namesCount.NameProportion("John"));
            //Console.WriteLine("Fraction of Marys: {0}", namesCount.NameProportion("Mary"));
            #endregion

            #region tollgatetest
            //Tollgate tollgate = new Tollgate();
            //tollgate.Enter("New York");
            //tollgate.Enter("LA");

            //Console.WriteLine(tollgate.Exit());
            //Console.WriteLine(tollgate.Exit());
            #endregion

            #region twosumtest
            //Tuple<int, int> indices = TwoSum.FindTwoSum(new List<int>() { 1, 3, 5, 7, 9 }, 12);
            //Console.WriteLine(indices.Item1 + " " + indices.Item2);
            #endregion

            #region binarysearchtreetest
            //Node n1 = new Node(1, null, null);
            //Node n3 = new Node(3, null, null);
            //Node n2 = new Node(2, n1, n3);

            //var isValidTree = BinarySearchTree.IsValidBinarySearchTree(n2);
            //Console.WriteLine(isValidTree.ToString());
            #endregion

            #region palindrometest
            //var isPalinDrome = Palindrome.IsPalindrome("Noel sees Leon");
            //var isPalinDrome = Palindrome.IsPalindrome("Nor Leon");
            //Console.WriteLine(isPalinDrome.ToString());
            #endregion

            #region calculatetreesize
            //TreeNode leaf1 = new TreeNode(null, null);
            //TreeNode leaf2 = new TreeNode(null, null);
            //TreeNode node = new TreeNode(leaf1, null);
            //TreeNode root = new TreeNode(node, leaf2);
            //Console.WriteLine(TreeHeight.CalculateHeight(root));
            #endregion

            #region eatcandiestest
            var eaten = CountCandies.calculateEaten(3, 2);
            Console.WriteLine(eaten.ToString());
            #endregion

            Console.ReadLine();
        }
    }
}
