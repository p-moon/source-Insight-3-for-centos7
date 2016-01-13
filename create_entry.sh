echo "[Desktop Entry]" >> sourceinsight.desktop
echo "Encoding=UTF-8" >> sourceinsight.desktop
echo "Name=Source Insight 3 by LovePrincessStudio(aifei8.net)" >> sourceinsight.desktop
echo "${WINELOADER:-wine}":"\ $aifei8_net_app_root/SourceInsight3/Insight3.exe" >> sourceinsight.desktop
echo "$aifei8_net_app_root/SourceInsight3/logo.png" >> sourceinsight.desktop
echo "Terminal=false" >> sourceinsight.desktop
echo "Type=Application" >> sourceinsight.desktop
echo "Categories=Development;" >> sourceinsight.desktop
echo "StartupNotify=true" >> sourceinsight.desktop
echo "X-Desktop-File-Install-Version=1.0" >> sourceinsight.desktop

desktop-file-install ./sourceinsight.desktop
