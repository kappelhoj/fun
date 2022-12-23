import pandas
progressionData = pandas.read_csv("Progression-clean.csv", quotechar="'")

progressionData.to_html('temp.html')