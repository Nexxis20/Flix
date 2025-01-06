@echo off

:loop
git add .
git commit -m "Update all files"
git push
timeout 5

goto loop