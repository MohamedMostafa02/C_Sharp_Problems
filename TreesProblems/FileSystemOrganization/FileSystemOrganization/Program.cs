using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemOrganization
{
    // Represents a file or directory in the file system
    class FileNode
    {
        // Name of the file or directory
        public string Name { get; set; }

        // Flag to indicate if the node is a file (true) or a directory (false)
        public bool IsFile { get; set; }

        // List of children nodes (only applies if this is a directory)
        public List<FileNode> Children { get; set; } = new List<FileNode>();

        // Enum to specify whether the node is a Directory or File
        public enum enType { Directory, File }

        // Constructor to initialize the FileNode with a name and type
        public FileNode(string name, enType fType)
        {
            Name = name;
            IsFile = fType == enType.File ? true : false; // If type is File, set IsFile to true
        }

        // Recursive method to print the file system hierarchy
        public void Print(string indent = "")
        {
            // Print the current node with indentation
            Console.WriteLine(indent + (IsFile ? "File: " : "Directory: ") + Name);

            // Recursively print all children nodes with increased indentation
            foreach (var child in Children)
            {
                child.Print(indent + "  ");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the root directory
            var root = new FileNode("root", FileNode.enType.Directory);

            // Create subdirectories
            var documents = new FileNode("Documents", FileNode.enType.Directory);
            var photos = new FileNode("Photos", FileNode.enType.Directory);

            // Add files to the Documents directory
            documents.Children.Add(new FileNode("Resume.docs", FileNode.enType.File));
            documents.Children.Add(new FileNode("Project.pdf", FileNode.enType.File));

            // Add files to the Photos directory
            photos.Children.Add(new FileNode("Vacation.jpg", FileNode.enType.File));
            photos.Children.Add(new FileNode("Diving.jpg", FileNode.enType.File));
            photos.Children.Add(new FileNode("Family.jpg", FileNode.enType.File));

            // Add subdirectories to the root directory
            root.Children.Add(documents);
            root.Children.Add(photos);

            // Print the file system hierarchy
            Console.WriteLine("File System:\n");
            root.Print();

            // Wait for a key press before closing the console
            Console.ReadKey();
        }
    }
}
