using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DirectoryComparer.Interfaces;
using DirectoryComparer.Objects;
using DirectoryComparer.Services;
using System.IO;

namespace DirectoryComparer.Comparers
{
    public class RecursiveImageComparer : ITwoPassComparer
    {
        private frmMain _reference;

        public RecursiveImageComparer(frmMain reference)
        {
            _reference = reference;
        }

        public List<CompareResult> LeftCompare(string leftFolder, string rightFolder)
        {
            return Compare(leftFolder, rightFolder);
        }

        public List<CompareResult> RightCompare(string rightFolder, string leftFolder)
        {
            return Compare(rightFolder, leftFolder);
        }

        private List<CompareResult> Compare(string firstFolder, string secondFolder)
        {
            var results = new List<CompareResult>();

            var leftFiles = DirectoryLister.GetAllFiles(firstFolder);
            var rightFiles = DirectoryLister.GetAllFiles(secondFolder);

            _reference.AddStepProgress();

            foreach (string fileOrFolder in leftFiles)
            {
                if (fileOrFolder.IsFile())
                {
                    results.Add(ProcessFile(fileOrFolder, rightFiles, CompareDirection.Left));
                }
                else if (DirectoryComparerBaseInfo.Recursive)
                {
                    results.AddRange(ProcessFolder(fileOrFolder, rightFiles, CompareDirection.Left));
                }
            }

            _reference.AddStepProgress();

            return results;
        }

        private List<CompareResult> ProcessFolder(string fileOrFolder, List<string> otherFiles, CompareDirection direction)
        {
            List<CompareResult> results = new List<CompareResult>();

            string dirName = '\\' + fileOrFolder.GetCurrentDir();
            string correspondingDir = otherFiles.SingleOrDefault(r => r.IsDirectory() && r.EndsWith(dirName));
            if (correspondingDir != null)
            {
                List<string> leftFiles = DirectoryLister.GetAllFiles(fileOrFolder);
                List<string> cRightFiles = DirectoryLister.GetAllFiles(correspondingDir);

                if (leftFiles.Count == 0 && cRightFiles.Count == 0)
                {
                    results.Add(ProcessEmptyDirectory(fileOrFolder, correspondingDir, direction));
                }
                else
                {
                    foreach (string fileorFolder in leftFiles)
                    {
                        results.AddRange(ProcessByType(fileorFolder, cRightFiles, direction));
                    }
                }
            }
            else
            {
                List<string> files = DirectoryLister.GetAllFiles(fileOrFolder);

                if (files.Count > 0)
                {
                    foreach (var file in files)
                    {
                        results.AddRange(ProcessByType(file, null, direction));
                    }
                }
                else
                {
                    results.Add(ProcessEmptyDirectory(fileOrFolder, string.Empty, direction));
                }
            }

            return results;
        }

        private CompareResult ProcessEmptyDirectory(string currentFolder, string correspondingFolder, CompareDirection direction)
        {
            CompareResult result = new CompareResult();
            result.FileName = string.Empty;
            result.FileExtension = string.Empty;

            if (direction == CompareDirection.Left)
            {
                result.LeftFilePath = currentFolder;
                result.RightFilePath = correspondingFolder;
                result.LeftCreatedDate = currentFolder != string.Empty ? Directory.GetCreationTime(currentFolder) : DateTime.MinValue;
                result.LeftModifiedDate = currentFolder != string.Empty ? Directory.GetLastWriteTime(currentFolder) : DateTime.MinValue;
                result.RightCreatedDate = correspondingFolder != string.Empty ? Directory.GetCreationTime(correspondingFolder) : DateTime.MinValue;
                result.RightModifiedDate = correspondingFolder != string.Empty ? Directory.GetLastWriteTime(correspondingFolder) : DateTime.MinValue;
                result.ExistsLeft = currentFolder != string.Empty;
                result.ExistsRight = correspondingFolder != string.Empty;
            }
            else
            {
                result.RightFilePath = currentFolder;
                result.LeftFilePath = correspondingFolder;
                result.RightCreatedDate = currentFolder != string.Empty ? Directory.GetCreationTime(currentFolder) : DateTime.MinValue;
                result.RightModifiedDate = currentFolder != string.Empty ? Directory.GetLastWriteTime(currentFolder) : DateTime.MinValue;
                result.LeftCreatedDate = correspondingFolder != string.Empty ? Directory.GetCreationTime(correspondingFolder) : DateTime.MinValue;
                result.LeftModifiedDate = correspondingFolder != string.Empty ? Directory.GetLastWriteTime(correspondingFolder) : DateTime.MinValue;
                result.ExistsRight = currentFolder != string.Empty;
                result.ExistsLeft = correspondingFolder != string.Empty;
            }

            result.Match = currentFolder != string.Empty && correspondingFolder != string.Empty;
            result.Compared = true;

            return result;
        }

        private CompareResult ProcessFile(string fileOrFolder, List<string> otherFiles, CompareDirection direction)
        {
            string file = otherFiles.SingleOrDefault(r => r.IsFile() && r.EndsWith('\\' + fileOrFolder.GetFileName()));
            CompareResult result = file != null ? ProcessFileInternal(fileOrFolder, file, direction)
                                                : ProcessFileInternal(fileOrFolder, string.Empty, direction);
            return result;
        }

        private CompareResult ProcessFileInternal(string fileOrFolder, string file, CompareDirection direction)
        {
            CompareResult result = new CompareResult();
            result.FileName = fileOrFolder.GetFileName();
            result.FileExtension = fileOrFolder.GetFileExtension();

            if (direction == CompareDirection.Left)
            {
                result.LeftFilePath = fileOrFolder;
                result.LeftCreatedDate = File.GetCreationTime(fileOrFolder);
                result.LeftModifiedDate = File.GetLastWriteTime(fileOrFolder);
                result.LeftHash = file != string.Empty ? MD5Hash.HashFile(fileOrFolder) : string.Empty;
                result.RightFilePath = file != string.Empty ? file : string.Empty;
                result.RightCreatedDate = file != string.Empty ? File.GetCreationTime(file) : DateTime.MinValue;
                result.RightModifiedDate = file != string.Empty ? File.GetLastWriteTime(file) : DateTime.MinValue;
                result.RightHash = file != string.Empty ? MD5Hash.HashFile(file) : string.Empty;
                result.ExistsLeft = true;
                result.ExistsRight = file != string.Empty;
            }
            else
            {
                result.RightFilePath = fileOrFolder;
                result.RightCreatedDate = File.GetCreationTime(fileOrFolder);
                result.RightModifiedDate = File.GetLastWriteTime(fileOrFolder);
                result.RightHash = file != string.Empty ? MD5Hash.HashFile(fileOrFolder) : string.Empty;
                result.LeftFilePath = file != string.Empty ? file : string.Empty;
                result.LeftCreatedDate = file != string.Empty ? File.GetCreationTime(file) : DateTime.MinValue;
                result.LeftModifiedDate = file != string.Empty ? File.GetLastWriteTime(file) : DateTime.MinValue;
                result.LeftHash = file != string.Empty ? MD5Hash.HashFile(file) : string.Empty;
                result.ExistsRight = true;
                result.ExistsLeft = file != string.Empty;
            }

            result.Match = file != string.Empty ? result.LeftHash == result.RightHash : false;
            result.Compared = true;
            result.IsFile = true;

            return result;
        }

        private List<CompareResult> ProcessByType(string fileOrFolder, List<string> compareItems, CompareDirection direction)
        {
            List<string> _compareItems = compareItems ?? new List<string>();
            List<CompareResult> results = new List<CompareResult>();
            if (fileOrFolder.IsFile())
            {
                results.Add(ProcessFile(fileOrFolder, _compareItems, direction));
            }
            else
            {
                results.AddRange(ProcessFolder(fileOrFolder, _compareItems, direction));
            }
            return results;
        }
    }
}
