# CMP1903 Report
---
My code was reviewed by Kieran Rawlings (25751176); Edward Olley (25769056); Anthony Goddard (25710847) and Samuel Harwood (TBD). 
---
The main Comments by Kieran were regarding lack of comments and error handling, whilst Ed noted that File Paths were not very intiutive to deal with. Anthony and Kieran both noted that the Regex was useful and potentially added to efficiency. However,when Ed stress-tested the code with a 1.3GB text file, the program produced an Out of Memory Error, however I have chosen not to handle this owing to the edge-case that this would be. 

Samuel H further noted that error handling is incomplete following their pull request and subsequent issue. This was as the try block was inadequate in spotting null inputs. They also noted that sentence count and upper-case letter count share a variable, a bug that I will rectify on the next commit following their pull. And they note that sentences ending in "!" or "?" are not counted, again something that will be atteneded to in the next commit. Additionally, they suggest that instead of values being a list, it could be a dictionary type and that the report output could be chnaged to use just one ``Console.WriteLine`` as opposed to 5. They also suggest the use of ``Get`` & ``Set`` to be used to encapsulate variables to protect them when sent to Report.cs.

---

In return I have reviewed the code of Anthony Goddard (see above), Daniel Wessels (25827459) and Liam Whitehead (25725278). I noted in the former two, some inefficienties and used the Issue tracker on GitHub to record as such. My approach was to read the code and try to execute the code on my machine to check functionality as well as try to understand the user interface. I subsequently went through the code and wrote an individual review for each file of sourcecode. I tried to be constructive without coming across as overly critical but am unsure if I was successful in doing so.
