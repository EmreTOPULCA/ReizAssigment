using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReizAssigment
{
    public class Branch
    {
        List<Branch> branches { get; set; }


        //Constructor method
        public Branch()
        {
            branches = new List<Branch>();

        }

        //Function that add new branch
        public void AddBranch(Branch branch)
        {
            branches.Add(branch);
        }

        //Function that get branch
        public Branch GetBranch(int index)
        {
            return branches[index];
        }


        public bool HasBranch()
        {
            return this.branches.Count > 0;
        }

        //Function that calculates depth using recursion
        public int CalculateDepth(int currentDepth = 1)
        {
            if (!branches.Any())
            {
                return currentDepth;
            }

            return branches.Max(branch => branch.CalculateDepth(currentDepth + 1));
                      
        }


        //Creation of the structure given in the task
        public static Branch InitializeTree()
        {
            Branch root = new Branch();
            Branch branch2 = new Branch();
            Branch branch3 = new Branch();
            root.AddBranch(branch2);
            root.AddBranch(branch3);
            Branch branch4 = new Branch();
            branch2.AddBranch(branch4);
            Branch branch5 = new Branch();
            Branch branch6 = new Branch();
            Branch branch7 = new Branch();
            branch3.AddBranch(branch5);
            branch3.AddBranch(branch6);
            branch3.AddBranch(branch7);
            Branch branch8 = new Branch();
            branch5.AddBranch(branch8);
            Branch branch9 = new Branch();
            Branch branch10 = new Branch();
            branch6.AddBranch(branch9);
            branch6.AddBranch(branch10);
            Branch branch11 = new Branch();
            branch9.AddBranch(branch11);            
            return root;
        }

    }
}
