Setup
-----------

	cd <empty folder of your choice>
	
	git init
	
	git clone https://github.com/Tarwine/otroniconJam.git
	
	git remote add upstream https://github.com/Tarwine/otroniconJam.git
	
	git fetch upstream
	
	
Main use cases
------------

Pushing to master

	git status
	
	git add .
	
	git commit -a -m "<message>"
	
	git push origin master
	
	
Pulling from master

	git fetch origin
	
	git merge origin/master
	

Possibly Unused
------------

Creating a branch

	git branch <name_of_your_branch>
	
	git push --set-upstream upstream <name_of_your_branch>
	

Switching branches

	git checkout <name_of_your_branch>
	
	
Pushing to current branch

	git status
	
	git add .
	
	git commit -a -m "<message>"
	
	git push origin <name_of_your_branch>
	
	
Pulling from branch

	git fetch <branchName>
	
	git merge origin/<name_of_your_branch>
	

Deleting a branch locally

	git branch -d <name_of_your_branch>
	
	
Refreshing remote branches

	git remote prune origin
	
