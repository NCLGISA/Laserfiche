## Script for Exporting Briefcase contents to a text file
## Copies the Briefcase as a tar file
## Extracts The File "toc.xml" from the tar file (toc = table of contents)
## Parses "toc.xml" and writes each line to a text file
## Counts each parsed line and revisits the text file
## Writes number of line as final line


import tarfile
import time
import os
import shutil
import xml.etree.ElementTree as ET

if __name__ == '__main__':
    files = os.listdir('.')

    for file in files:
        if file.endswith('.lfb'):
            filename = file.split('.lfb')
            briefcaseDirectory = filename[0]
            os.makedirs(briefcaseDirectory)
            tarFileName = filename[0]+'.tar.gz'
            txtFileName = filename[0] + '.txt'
            os.popen('copy %s %s'%(file,tarFileName))
            time.sleep(5) ## Gives Files time to create
            shutil.move(tarFileName, briefcaseDirectory)
            os.chdir(briefcaseDirectory)
            tar = tarfile.open(tarFileName)
            tar.extract('toc.xml')
            tar.close()
            totalCount = 0
            tree = ET.parse('toc.xml')
            root = tree.getroot()
            for child in root:
                childattrib = child.attrib
                with open(txtFileName, 'a') as txtFile:
                    txtFile.write(childattrib['name']+'\n')
                    totalCount = totalCount + 1
                    txtFile.close()

            with open(txtFileName, 'a') as txtFile:
                txtFile.write('Total Number Of Files: ' + str(totalCount) )
            os.chdir('..')
            
            
