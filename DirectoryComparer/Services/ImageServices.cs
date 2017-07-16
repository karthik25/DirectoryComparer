using System.Linq;
using System.IO;
using DirectoryComparer.Objects;
using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using MetadataExtractor.Formats.Jpeg;

namespace DirectoryComparer.Services
{
    public static class ImageServices
    {
        public static bool Compare(string image1, string image2)
        {
            var extension1 = Path.GetExtension(image1).ToLower();
            var extension2 = Path.GetExtension(image2).ToLower();

            if (extension1 == null || extension2 == null || !extension1.Equals(extension2)) return false;

            // todo convert supported formats to enum
            switch (extension1.ToLower())
            {
                case ImageFormat.JPEG:
                    return CopmareJPEGImages(image1, image2);
                case ImageFormat.NEF:
                    return CopmareNEFImages(image1, image2);
                case ImageFormat.CR2:
                    return CopmareNEFImages(image1, image2);
            }

            return false;

        }

        private static bool CopmareJPEGImages(string image1, string image2)
        {
            try
            {
                var metadataImage1 = ImageMetadataReader.ReadMetadata(image1);
                var metadataImage2 = ImageMetadataReader.ReadMetadata(image2);

                var subIfdDirectory1 = metadataImage1.OfType<ExifSubIfdDirectory>().FirstOrDefault();
                var subIfdDirectory2 = metadataImage2.OfType<ExifSubIfdDirectory>().FirstOrDefault();

                // Camera maker + model
                var heightEquals = CompareDir(ExifDirectoryBase.TagExifImageHeight, subIfdDirectory1, subIfdDirectory2);
                if (!heightEquals) return false;

                var widthEquals = CompareDir(ExifDirectoryBase.TagExifImageWidth, subIfdDirectory1, subIfdDirectory2);
                if (!widthEquals) return false;

                var exposureTimeEquals = CompareDir(ExifDirectoryBase.TagExposureTime, subIfdDirectory1, subIfdDirectory2);
                if (!exposureTimeEquals) return false;

                var fNumberEquals = CompareDir(ExifDirectoryBase.TagFNumber, subIfdDirectory1, subIfdDirectory2);
                if (!fNumberEquals) return false;

                var dateTimeOriginalEquals = CompareDir(ExifDirectoryBase.TagDateTimeOriginal, subIfdDirectory1, subIfdDirectory2);
                if (!dateTimeOriginalEquals) return false;

                var dateTimeDigitizedEquals = CompareDir(ExifDirectoryBase.TagDateTimeDigitized, subIfdDirectory1, subIfdDirectory2);
                if (!dateTimeDigitizedEquals) return false;

                var jpegDirectory1 = metadataImage1.OfType<JpegDirectory>().FirstOrDefault();
                var jpegDirectory2 = metadataImage2.OfType<JpegDirectory>().FirstOrDefault();

                var jpgWidth = CompareDir(ExifDirectoryBase.TagImageWidth, jpegDirectory1, jpegDirectory2);
                if (!jpgWidth) return false;

                var jpgHeight = CompareDir(ExifDirectoryBase.TagImageHeight, jpegDirectory1, jpegDirectory2);
                if (!jpgHeight) return false;

            }
            catch (ImageProcessingException e)
            {
                return false;
            }
            catch (IOException e)
            {
                return false;
            }

            return true;
        }

        private static bool CopmareNEFImages(string image1, string image2)
        {
            try
            {
                var metadataImage1 = ImageMetadataReader.ReadMetadata(image1);
                var metadataImage2 = ImageMetadataReader.ReadMetadata(image2);

                var subIfdDirectory1 = metadataImage1.OfType<ExifSubIfdDirectory>().FirstOrDefault();
                var subIfdDirectory2 = metadataImage2.OfType<ExifSubIfdDirectory>().FirstOrDefault();

                var exposureTimeEquals = CompareDir(ExifDirectoryBase.TagExposureTime, subIfdDirectory1, subIfdDirectory2);
                if (!exposureTimeEquals) return false;

                var fNumberEquals = CompareDir(ExifDirectoryBase.TagFNumber, subIfdDirectory1, subIfdDirectory2);
                if (!fNumberEquals) return false;

                var dateTimeOriginalEquals = CompareDir(ExifDirectoryBase.TagDateTimeOriginal, subIfdDirectory1, subIfdDirectory2);
                if (!dateTimeOriginalEquals) return false;

                var dateTimeDigitizedEquals = CompareDir(ExifDirectoryBase.TagDateTimeDigitized, subIfdDirectory1, subIfdDirectory2);
                if (!dateTimeDigitizedEquals) return false;

                var ifd0Directory1 = metadataImage1.OfType<ExifIfd0Directory>().FirstOrDefault();
                var ifD0Directory2 = metadataImage2.OfType<ExifIfd0Directory>().FirstOrDefault();

                var heightEquals = CompareDir(ExifDirectoryBase.TagImageHeight, ifd0Directory1, ifD0Directory2);
                if (!heightEquals) return false;

                var widthEquals = CompareDir(ExifDirectoryBase.TagImageWidth, ifd0Directory1, ifD0Directory2);
                if (!widthEquals) return false;

                var dateTime = CompareDir(ExifDirectoryBase.TagDateTime, ifd0Directory1, ifD0Directory2);
                if (!dateTime) return false;

                var dateTimeOrg = CompareDir(ExifDirectoryBase.TagDateTimeOriginal, ifd0Directory1, ifD0Directory2);
                if (!dateTimeOrg) return false;

                var model = CompareDir(ExifDirectoryBase.TagModel, ifd0Directory1, ifD0Directory2);
                if (!model) return false;

                var make = CompareDir(ExifDirectoryBase.TagMake, ifd0Directory1, ifD0Directory2);
                if (!make) return false;

            }
            catch (ImageProcessingException e)
            {
                return false;
            }
            catch (IOException e)
            {
                return false;
            }

            return true;
        }


        /// <summary>
        /// Copmare if two exif tags has the same value
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="subDir1"></param>
        /// <param name="subDif2"></param>
        /// <returns>true if not null and has the same value</returns>
        private static bool CompareDir(int tag, MetadataExtractor.Directory subDir1, MetadataExtractor.Directory subDif2)
        {
            var width1 = subDir1?.GetDescription(tag);
            var width2 = subDif2?.GetDescription(tag);

            if (width1 == null && width2 == null) return true;

            return (width1 != null && width1.Equals(width2));
        }
    }
}
