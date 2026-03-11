1. If since you created your feature branch, no new commits have been added to the main branch
than fast-forward is performed, otherwise (if some commits were done on the branch from where we diverged)
merge is performed.
2. When merge is performed you connect "tips" of the two branches (e.g. main and feature) and a new merge commit is created
to unite two branches, in the case of rebase you "rip off" branch and reconnect it to the top of the main branch creating 
single line of commits.
3. In my case two commits conflicted as the both changed same Console.WriteLine but provided different messages
I chose to go with the change that was provided by main branch