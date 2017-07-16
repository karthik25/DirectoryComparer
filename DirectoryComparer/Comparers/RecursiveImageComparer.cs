using System.Collections.Generic;
using DirectoryComparer.Interfaces;
using DirectoryComparer.Objects;
using DirectoryComparer.Services;
using System.IO;
using System.Linq;

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
            _reference.ReportProgress(20);
            var jpegA = DirectoryLister.GetJPGImages(leftFolder);
            _reference.ReportProgress(25);
            var jpegB = DirectoryLister.GetJPGImages(rightFolder);
            _reference.ReportProgress(30);
            var rawCanonA = DirectoryLister.GetRawCanonImages(leftFolder);
            _reference.ReportProgress(35);
            var rawCanonB = DirectoryLister.GetRawCanonImages(rightFolder);
            _reference.ReportProgress(40);
            var rawNikonA = DirectoryLister.GetRawNilonImages(leftFolder);
            _reference.ReportProgress(45);
            var rawNikonB = DirectoryLister.GetRawNilonImages(rightFolder);
            _reference.ReportProgress(50);

            _reference.ReportProgress(60);
            var jpgResults = Compare(jpegA, jpegB);
            _reference.ReportProgress(70);
            var rawCanonResults = Compare(rawCanonA, rawCanonB);
            _reference.ReportProgress(80);
            var rawNilkonResults = Compare(rawNikonA, rawNikonB);
            _reference.ReportProgress(90);

            return jpgResults.Concat(rawCanonResults).Concat(rawNilkonResults).ToList();
        }

        public List<CompareResult> RightCompare(string rightFolder, string leftFolder)
        {
            return new List<CompareResult>();
        }

        private List<CompareResult> Compare(List<string> folderA, List<string> folderB)
        {
            var results = new List<CompareResult>();

            var sideBWorkingSet = new List<string>();
            folderB.ForEach(f => sideBWorkingSet.Add(f));

            // Go over all the images
            foreach (var image in folderA)
            {
                var imageIndex = LookForImages(image, folderB);

                // Duplication found
                results.AddRange(imageIndex.Select(i => new CompareResult()
                {
                    FileName = Path.GetFileName(image),
                    LeftFilePath = image,
                    LeftCreatedDate = File.GetCreationTime(image),
                    LeftModifiedDate = File.GetLastWriteTime(image),
                    Compared = true,
                    ExistsLeft = true,
                    ExistsRight = true,
                    RightFilePath = folderB[i],
                    Match = true,
                    RightCreatedDate = File.GetCreationTime(folderB[i]),
                    RightModifiedDate = File.GetLastWriteTime(folderB[i]),

                }));

                // Remove duplication from list B
                foreach (var i in imageIndex.OrderByDescending(v => v))
                    sideBWorkingSet.RemoveAt(i);

                // Duplication was not found
                if (imageIndex.Count <= 0)
                {
                    results.Add(new CompareResult()
                    {
                        FileName = Path.GetFileName(image),
                        LeftFilePath = image,
                        LeftCreatedDate = File.GetCreationTime(image),
                        LeftModifiedDate = File.GetLastWriteTime(image),
                        Compared = true,
                        ExistsLeft = true,
                        ExistsRight = false,
                    });
                }
            }

            // Files in list B but not in list A
            foreach (var image in sideBWorkingSet)
            {
                var imageResult = new CompareResult()
                {
                    FileName = Path.GetFileName(image),
                    RightFilePath = image,
                    RightCreatedDate = File.GetCreationTime(image),
                    RightModifiedDate = File.GetLastWriteTime(image),
                    Compared = true,
                    ExistsLeft = false,
                    ExistsRight = true
                };

                results.Add(imageResult);
            }

            return results;
        }

        private List<int> LookForImages(string image, List<string> lookIn)
        {
            var indexes = new List<int>();

            for (var i = 0; i < lookIn.Count; i++)
            {
                if (ImageServices.Compare(image, lookIn[i]))
                    indexes.Add(i);
            }

            return indexes;
        }
    }
}
