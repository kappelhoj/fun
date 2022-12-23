import re

file = open("progression-clean.csv")
lines = file.readlines()

invalidLineCount = 0 
lineCount = 0

for line in lines:
    escapedLine = re.sub("['].*[']", "",line)
    count = escapedLine.count(',')
    lineCount += 1

    if(count > 17):
        #print(escapedLine)
        invalidLineCount+= 1
        print("Invalid line at: ", lineCount)
        

print(invalidLineCount)


    