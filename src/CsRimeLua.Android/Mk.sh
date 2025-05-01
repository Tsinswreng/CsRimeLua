# 編譯並移至本機用戶目錄
# 在wsl
export ANDROID_HOME="/mnt/d/ENV/_wsl/tools_r25.2.3-linux"
export ANDROID_NDK_HOME="/mnt/d/ENV/_wsl/android-ndk-r27c"
dotnet publish -c Release -r linux-bionic-arm64
#E:/_code/CsRimeLua/src/CsRimeLua.Android/

mv ./bin/Release/net9.0/linux-bionic-arm64/publish/CsRimeLua.Android.so "/mnt/d/Program Files/Rime/User_Data/lua/Tsinswreng/_NativeLib/linux-bionic-arm64/libCsRimeLua.so"