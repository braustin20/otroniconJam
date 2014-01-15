Setup
-----------

	cd <empty_folder_of_your_choice>
	
	git init
	
	git clone https://github.com/Tarwine/otroniconJam.git
	
	git remote add upstream https://github.com/Tarwine/otroniconJam.git
	
	git fetch upstream
	
	
Main use cases
------------

Pushing to master

	git status
	
	git add --all
	
	git commit -m "<message_describing_changes>"
	
	git push upstream master
	
	
Pulling from master

	git fetch upstream
	
	git merge upstream/master
	

Possibly Unused (Branches)
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
	
	git push upstream <name_of_your_branch>
	
	
Pulling from branch

	git fetch <branchName>
	
	git merge upstream/<name_of_your_branch>
	

Deleting a branch locally

	git branch -d <name_of_your_branch>
	
	
Refreshing remote branches

	git remote prune upstream
	
