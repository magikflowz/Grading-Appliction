import shutil 
import os 

shutil.copytree("C:/Users/Magik/Desktop/grading_app", "C:/Users/Magik/Desktop/aurbina_application")

source = os.listdir("C:/Users/Magik/Desktop/grading_app")
destination = os.listdir("C:/Users/Magik/Desktop")
for files in source:
    if files.endwith(".exe"):
        shutil.move(files,destination)
        print("Complete Press Any Button to exit")



