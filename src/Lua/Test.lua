local dllPath = "./bin/Release/net9.0/win-x64/publish/CsRimeLua.Windows.dll"
local fnName = "Test"
local fn,err = package.loadlib(dllPath,fnName)
if err then
	print(err)
	return
end
local myTable = {a="hello"}
local result = fn(myTable)
print(result)
