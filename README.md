# IPTV CLEANER

Dellete all extensions that you don´t need in your m3u.txt

  - Set your input file in program.cs
  - Set your output file in program.cs

# Add or delete extensions in ServiceCleaner.cs.

    "mp4", "mkv", "avi"

# Run 
    Download App folder
    Open terminal ( cmd in windows )
    Navigate to App folder
    Modify m3u.txt with your iptvs ips.
    Run .\IptvCleaner.exe
    A output.txt will be generated.
    
# Example
Input:

    #EXTM3U
    #EXTINF:-1,----- TEST IPTV -------
    http://test/test/6862.ts
    #EXTINF:-1, TEST HD
    http://test/test/168693.mkv
    #EXTINF:-1,TEST
    http://test/test/226337.mkv
    #EXTINF:-1,47 TEST
    http://test/test/82352.mkv
    #EXTINF:-1 TEST
    http://test/test/82362.avi
    #EXTINF:-1,100 TEST
    http://test/test/88821.mp4
    #EXTINF:-1,NOR: TEST
    http://test/test/132084.ts
    #EXTINF:-1,NOR: TEST
    http://test/test/132083.ts
    #EXTINF:-1,NOR: TEST
    http://test/test/132082.ts
    #EXTINF:-1,NOR: TEST
    http://test/test/132081.ts
   
output:

    #EXTINF:-1,----- TEST IPTV -------
    http://test/test/6862.ts
    #EXTINF:-1,NOR: TEST
    http://test/test/132084.ts
    #EXTINF:-1,NOR: TEST
    http://test/test/132083.ts
    #EXTINF:-1,NOR: TEST
    http://test/test/132082.ts
    #EXTINF:-1,NOR: TEST
    http://test/test/132081.ts
