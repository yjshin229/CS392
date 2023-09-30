# CS392 🖥️

## Git Commit convention
1. Make a branch before you start working on your code. <br>
``` git checkout -b <new branch name> ```
   >branch names: <br>
   > ex) feature: p.p calculator, fix: p.p 8.4
2. After you are done with implementing each programming assignment, create a PR to ```dev```.
   > Don't forget to pull from dev before creating a PR!
   > You might also have to fast-forward your current working branch to dev in order to prevent merge conflicts.
  
   > The PR title should be something similar to your branch name. Something that is easy to understand! <br>
  ```feature: implement calculator app 7.4```
   
3. Review the PR.
   > ```dev``` is a protected branch. We need your reviews and approval in order to merge.
   > read your peer's code and add comments to them if needed!
   > It would be great if you switch out to their branch and test it with the simulator running.
   
   ```git fetch --all``` will fetch all the remote branches.<br>
   
4. We merge them to ```dev```.
   > When we are done reviewing and there are no conflicts we will merge to dev.

5. After we are done with each week's assignment I will merge ```dev``` to ```main```.
   > ⭐ So remember to pull before starting any work!! 

## Useful stuff
⚠️ If there is an error doing ```pull``` try ```git config --global pull.rebase true```. <br>
(I use rebase for default when pulling.)

⭐ we usually don't use past tense for git commit, branches, PR.
  
|branch prefix| use|
|--|--|
|hotfix|	for quickly fixing critical issues usually with a temporary solution|
|fix|	for fixing a bug|
|feature|	for adding, removing or modifying a feature|
|WIP|	for a work in progress|
