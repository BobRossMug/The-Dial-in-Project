# The Dial-in Project
---
The Dial-in project is a simple video-game-alike simulation for learning how to dial in coffee. If you'd like to know more about coffee, check the wiki link :

[About Coffee](https://github.com/BobRossMug/The-Dial-in-Project/wiki)

## Disclaimer : Project is NOT ready for grading

---

## Content and Hyperlinks 
- [The Tasks (AKA project requirements / T1-15 / Software Engineering Tasks)](#list-of-tasks-software-engineering)
-
-
-
-
-


---
---
---


## List of Tasks (Software Engineering) :exclamation::exclamation::exclamation:
---
## Task :one: : Use and Understand GIT :red_circle:
### Task Description : Use and understand GIT, and be able to apply the basic commands. Can you experiment with time travelling or branches/merges? E.g. add some screenshots, add a paragraph text or show by reference/link into the commits, that you applied all the commands.
---

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
## Task :two: : UML :white_check_mark: :red_circle: //USE CASE DIAGRAM IS WRONG
### Task Description : at least 3 big different diagrams. "big" means you can pump it up artificially as written in DDD. You have 10 million $ from me! Please export the pics. I can not install all the tools to view them! For example, these diagrams are a good idea: Use-Case, Component D, Class D, and Activity Diagram.
---
![UML - Class Diagram](https://github.com/user-attachments/assets/22317317-f4e6-40ff-bb77-ca3d6e3bc37b)
Class Diagram ^

![UML - Use Case](https://github.com/user-attachments/assets/35336108-a9aa-4832-b182-16219bcb8f5d)^
Use Case Diagram ^^  // FIX USE CASE DIAGRAM

![UML - Activity Diagram](https://github.com/user-attachments/assets/915f57dc-3daa-4040-b56f-0be5727edb1c)
Activity Diagram ^^^

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
## Task :three: : REQUIREMENTS :white_check_mark: :red_circle: // MISSING PROFESSIONAL TOOL
### Task Description : Create 5-10 good requirements for your project. Then put them into a simple tool (like Airtable, Notion or Trello) and a professional tool (like Monday, Jira, Doors, ObjectIF, Xebrio, etc.) Instead of the professional version, you can also build a tool yourself; e.g. with AI! If you have used AI / LLMs here, briefly describe where and how! However, it is more important here that some / many attributes are used!
---

![trello board](https://github.com/user-attachments/assets/cd7739c7-9c62-49ca-8856-45ba3bd41673)

// ADD PROFESSIONAL TOOL (Jira, Monday, Xebrio)

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
## Task :four: : ANALYSIS :red_circle:
### Task Description : A) Think about your checklist (on an extra A4 page) from all the points of the ‘ANA - Analysis’ learning unit, with the points that you consider relevant for your project (e.g. 10-15 instead of 30 on the overall picture) B) Carry out an analysis of your semester project / your favourite project. Or have a start-up idea and would like to hand in the start-up analysis as part of a large documentary! There should be at least 2 pages. Take the 10-15 points from the checklist (with e.g. 1-2 paragraphs per point). Assume that you will soon have a fishing rod for the start-up chapter. If you are successful, you would receive a lot of ‘money’ in order to be allowed to design and implement it later. So get your start-up off to a successful start! The use of large language models is explicitly encouraged here! However, don't try to solve everything with one prompt and then submit 10 pages: get specific help!Provide the prompts in brackets that have helped you to improve or structure something here! Please find the sweet spot between your own work/testing and content generation in order to learn something yourself throughout the entire process!
---

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
## Task :five: : DDD :red_circle:
### Task Description : (A) Do an Event-Storming to find your Domains! If your domain is too small, invent other domains around and document these domains (as if you have 100 Mio € from Edlich-Investment!) (B). Drop your Domains into a Core Domain Chart (C) and indicate the Relations = Mappings (! see MIRO examples again) between the Domains in a new diagram!
---


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
## Task :six: : METRICS :red_circle:
### Task Description : at least two. Sonarcube would be great. Other non-trivial metrics are also fine. Run the tools, document the output with screenshots, and explain what these Metrics or e.g. style errors mean!
---



///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
## Task :seven: : CLEAN CODE DEVELOPMENT :red_circle:
### Task Description : A) At least 5 points you can show me with an explanation of why this is clean code in your code and/or what has improved & B) >>10 points on your personal CCD cheat sheet. E.g. a PDF.
---


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
## Task :eight: : REFACTORING :white_check_mark:
### Task Description : Show me two (non-trivial) Refactoring Examples of your code! Showing the original content and the refactored code! Explain what happened, why and how it has improved! Again: do not send me pure AI work!
---

`Example one :` Name Refactoring 
This is a simpler example of refactoring, but the GameManager script of the game was renamed to SimManager. GameManager is a typcial script to be found inside Unity as games as a way to control system variables for the game environment. I found this to be necessary as running everything inside the GameManager wasn't very optimal as mutliple assets requires this script to be initialised for their function. I also made a seperate GameManager script to handle those variables.

![refactor e1](https://github.com/user-attachments/assets/995044f4-2b1c-4a23-a28a-99faf9f85a20)


`Example two :`  Extract Method
This example is a function extract, as a way to call DontDestroyOnLoad in a more optimal manner. In Unity (before 2021.3.0) DDOL calls can have this error where it will not function properly if the script is attached to multiple obejcts. This method allows you to fix this.

![R2](https://github.com/user-attachments/assets/bb3636d3-40f7-493d-b5be-3025b999b27e)


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
## Task :nine: : BUILD :red_circle:
### Task Description : Management with any Build System as Ant, Maven, Gradle, etc. (only Travis is perhaps not enough) Do e.g. generate Docs, call tests, etc. (it could also be disconnected from the project just to learn a build tool!) => to be merged with 7!
---


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
## Task :one::zero: : CONTINOUS DELIVERY :red_circle:
### Task Description : show me your pipeline using e.g. Jenkins, GitHub Actions, GitLab CI, etc. E.g. you can also use Jenkins Pipelining or BlueOcean, etc. But at least insert more than 2 script calls as done in the lecture! (e.g. also call Ant or Gradle or something else).
---


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
## Task :one::one: : UNIT TESTS :red_circle:
### Task Description : Integrate some nice UNIT TESTS in your Code to be integrated into the Build!
---


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
## Task :one::two: : IDE :white_check_mark:
### Task Description : Use a good IDE and get fluent with it: e.g. VSCode, IntelliJ. What are your favourite key shortcuts?!
---

I used intelliJ as my IDE, as it has been my default choice for the last 10 years. JetBrains Rider is a very powerful IDE to use alongside Unity. Here are my favorite shortcut : 

`Double Shift` : General search function. I use this mostly to switch between scripts 
`CTRL+Shift+E` : Navigate to recent. This is also useful to locate assets with attached scripts within unity straight from the code environment
`CTRL+K` : Commit! This is very useful. In Rider it automatically directs you to the commit message screen
`CTRL+Alt+Shift+T` Refactor "this". Useful when refactoring multiple things

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
## Task :one::three: : AI Coding :red_circle: 
### Task Description : Set Up an AI-coding environment on your computer like ZED, Aider, free Cursor / Windsurf, GitHub Copilot programs, etc. (some have free tiers). Show your steps and personal experiences! 
---


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
## Task :one::four: : FUNCTIONAL PROGRAMMING :red_circle:
### Task Description : 14. prove that you have covered all functional aspects in your code as:, only final data structures, (mostly) side-effect-free functions, the use of higher-order functions, functions as parameters and return values, use closures / anonymous functions. You can also do it outside of your project. Even in other languages such as F#, Clojure, Julia, etc.
