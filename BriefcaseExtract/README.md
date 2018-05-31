# Briefcase Extract

| Developer|Language|
| -------------|:----:
| Mark McIntyre| Python 3|

Our Tax department sends our Abstracts to a scanning service every year. The scanning service then sends the files back in the form of Laserfiche Briefcases. The Tax Department wanted a way to see the files IN the briefcase BEFORE they imported the Briefcases into Laserfiche(Audit). After researching, I found that Briefcases are "glorified" tar files. Inside the tar files is a file called "toc.xml". "toc.xml" contains all file information of files inside the briefcase.

What the script does is this, in order.

1. Loops through the directory, and finds all files ending in .lfb
2. Makes a directory named as the briefcase
3. Makes a copy of the briefcase, in tarball format.
4. Moves that tarball file to the directory, and extracts "toc.xml".
5. XML parser parses "toc.xml" and extracts all file names and writes the filenames to a txt file.
6. While parsing, it runs a counter of files.
7. Then revisits the txt file and writes the number of files in that txt file.
