S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.4
Build-Number: R720XXU2CPB7
Build-Date: 2016.02.24 22:13:42

Crash Information
Process Name: basicui
PID: 3034
Date: 2016-03-26 00:22:16+0100
Executable File Path: /opt/usr/apps/org.example.basicui/bin/basicui
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x6c

Register Information
r0   = 0x42e02400, r1   = 0x40001daa
r2   = 0xbee96b78, r3   = 0x00000010
r4   = 0xbee96b80, r5   = 0xbee96b78
r6   = 0x00000000, r7   = 0xbee96c1c
r8   = 0xbee96d3c, r9   = 0x40484c40
r10  = 0x40001daa, fp   = 0xbee96b64
ip   = 0x40331140, sp   = 0xbee96600
lr   = 0x40327ee4, pc   = 0x40327ee4
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     11168 KB
Buffers:     15820 KB
Cached:     167432 KB
VmPeak:      80476 KB
VmSize:      80296 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18644 KB
VmRSS:       18640 KB
VmData:      23056 KB
VmStk:        1012 KB
VmExe:           8 KB
VmLib:       51568 KB
VmPTE:          50 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 3034 TID = 3034
3034 3035 3036 3037 

Maps Information
40000000 40002000 r-xp /opt/usr/apps/org.example.basicui/bin/basicui
4000a000 4000b000 rwxp /opt/usr/apps/org.example.basicui/bin/basicui
4000b000 40028000 r-xp /lib/ld-2.13.so
4002f000 40030000 r-xp /lib/ld-2.13.so
40030000 40031000 rwxp /lib/ld-2.13.so
40031000 40035000 r-xp /usr/lib/libsys-assert.so
4003d000 4003e000 rwxp /usr/lib/libsys-assert.so
4003e000 4003f000 r-xp /usr/share/locale/locale-archive
4003f000 4004a000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
40052000 40053000 rwxp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
40053000 40057000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4005e000 4005f000 rwxp /usr/lib/libcapi-appfw-application.so.0.3.2.5
4005f000 40063000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
4006b000 4006c000 rwxp /usr/lib/libcapi-system-sensor.so.0.1.18
4006c000 40074000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
40074000 40075000 rwxp /usr/lib/libcapi-system-system-settings.so.0.0.2
40075000 40077000 r-xp /usr/lib/libdlog.so.0.0.0
4007e000 4007f000 rwxp /usr/lib/libdlog.so.0.0.0
4007f000 400a0000 r-xp /usr/lib/libefl-extension.so.0.1.0
400a7000 400a8000 rwxp /usr/lib/libefl-extension.so.0.1.0
400a8000 401e2000 r-xp /usr/lib/libelementary.so.1.7.99
401e9000 401f1000 rwxp /usr/lib/libelementary.so.1.7.99
401f8000 402c6000 r-xp /usr/lib/libevas.so.1.7.99
402ce000 402d8000 rwxp /usr/lib/libevas.so.1.7.99
402eb000 40406000 r-xp /lib/libc-2.13.so
4040e000 40410000 r-xp /lib/libc-2.13.so
40410000 40411000 rwxp /lib/libc-2.13.so
40414000 4041c000 r-xp /lib/libgcc_s-4.6.so.1
4041c000 4041d000 rwxp /lib/libgcc_s-4.6.so.1
4041d000 40428000 r-xp /lib/libunwind.so.8.0.1
4042f000 40430000 rwxp /lib/libunwind.so.8.0.1
40455000 40457000 r-xp /lib/libdl-2.13.so
4045e000 4045f000 r-xp /lib/libdl-2.13.so
4045f000 40460000 rwxp /lib/libdl-2.13.so
40460000 40464000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4046c000 4046d000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
4046d000 4046f000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
40477000 40478000 rwxp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
40478000 4047d000 r-xp /usr/lib/libappcore-efl.so.1.1
40484000 40485000 rwxp /usr/lib/libappcore-efl.so.1.1
40485000 4048a000 r-xp /usr/lib/libappcore-common.so.1.1
40491000 40492000 rwxp /usr/lib/libappcore-common.so.1.1
40492000 4049e000 r-xp /usr/lib/libaul.so.0.1.0
404a6000 404a7000 rwxp /usr/lib/libaul.so.0.1.0
404a8000 404ca000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
404d1000 404d2000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
404d2000 40513000 r-xp /usr/lib/libeina.so.1.7.99
4051a000 4051c000 rwxp /usr/lib/libeina.so.1.7.99
4051c000 40530000 r-xp /lib/libpthread-2.13.so
40537000 40538000 r-xp /lib/libpthread-2.13.so
40538000 40539000 rwxp /lib/libpthread-2.13.so
4053b000 40559000 r-xp /usr/lib/libsensor.so.1.1.0
40561000 40562000 rwxp /usr/lib/libsensor.so.1.1.0
40563000 405f7000 r-xp /usr/lib/libstdc++.so.6.0.16
405ff000 40602000 r-xp /usr/lib/libstdc++.so.6.0.16
40602000 40604000 rwxp /usr/lib/libstdc++.so.6.0.16
4060a000 40673000 r-xp /lib/libm-2.13.so
4067a000 4067b000 r-xp /lib/libm-2.13.so
4067b000 4067c000 rwxp /lib/libm-2.13.so
4067c000 406cc000 r-xp /usr/lib/libecore_x.so.1.7.99
406cc000 406ce000 rwxp /usr/lib/libecore_x.so.1.7.99
406ce000 406f0000 r-xp /usr/lib/libecore_evas.so.1.7.99
406f7000 406f9000 rwxp /usr/lib/libecore_evas.so.1.7.99
406f9000 406fd000 r-xp /usr/lib/libvconf.so.0.2.45
40704000 40705000 rwxp /usr/lib/libvconf.so.0.2.45
40705000 4072d000 r-xp /usr/lib/libfontconfig.so.1.8.0
4072d000 4072e000 rwxp /usr/lib/libfontconfig.so.1.8.0
4072e000 407fa000 r-xp /usr/lib/libxml2.so.2.7.8
40801000 40806000 rwxp /usr/lib/libxml2.so.2.7.8
40807000 408d7000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
408d7000 408d8000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
408d8000 408ea000 r-xp /usr/lib/libefl-assist.so.0.1.0
408f1000 408f2000 rwxp /usr/lib/libefl-assist.so.0.1.0
408f2000 40909000 r-xp /usr/lib/libecore.so.1.7.99
40911000 40912000 rwxp /usr/lib/libecore.so.1.7.99
40920000 4097d000 r-xp /usr/lib/libedje.so.1.7.99
40985000 40987000 rwxp /usr/lib/libedje.so.1.7.99
40987000 40a3f000 r-xp /usr/lib/libcairo.so.2.11200.14
40a46000 40a49000 rwxp /usr/lib/libcairo.so.2.11200.14
40a4a000 40b2b000 r-xp /usr/lib/libX11.so.6.3.0
40b32000 40b36000 rwxp /usr/lib/libX11.so.6.3.0
40b36000 40b3f000 r-xp /usr/lib/libXi.so.6.1.0
40b46000 40b47000 rwxp /usr/lib/libXi.so.6.1.0
40b47000 40b60000 r-xp /usr/lib/libeet.so.1.7.99
40b68000 40b69000 rwxp /usr/lib/libeet.so.1.7.99
40b71000 40b76000 r-xp /usr/lib/libecore_file.so.1.7.99
40b7d000 40b7e000 rwxp /usr/lib/libecore_file.so.1.7.99
40b7e000 40b8f000 r-xp /usr/lib/libecore_input.so.1.7.99
40b96000 40b97000 rwxp /usr/lib/libecore_input.so.1.7.99
40b97000 40ba0000 r-xp /usr/lib/libedbus.so.1.7.99
40ba7000 40ba8000 rwxp /usr/lib/libedbus.so.1.7.99
40ba8000 40bd2000 r-xp /usr/lib/libdbus-1.so.3.8.12
40bda000 40bdb000 rwxp /usr/lib/libdbus-1.so.3.8.12
40bdb000 40bf5000 r-xp /usr/lib/libecore_con.so.1.7.99
40bfc000 40bfd000 rwxp /usr/lib/libecore_con.so.1.7.99
40bfe000 40c11000 r-xp /usr/lib/libfribidi.so.0.3.1
40c18000 40c19000 rwxp /usr/lib/libfribidi.so.0.3.1
40c19000 40c56000 r-xp /usr/lib/libharfbuzz.so.0.940.0
40c5d000 40c5e000 rwxp /usr/lib/libharfbuzz.so.0.940.0
40c5f000 40cb5000 r-xp /usr/lib/libfreetype.so.6.11.3
40cbd000 40cc1000 rwxp /usr/lib/libfreetype.so.6.11.3
40cc1000 40d17000 r-xp /usr/lib/libpixman-1.so.0.28.2
40d1f000 40d24000 rwxp /usr/lib/libpixman-1.so.0.28.2
40d24000 40d2a000 r-xp /usr/lib/libappsvc.so.0.1.0
40d31000 40d32000 rwxp /usr/lib/libappsvc.so.0.1.0
40d32000 40d35000 r-xp /usr/lib/libbundle.so.0.1.22
40d3c000 40d3d000 rwxp /usr/lib/libbundle.so.0.1.22
40d3d000 40d43000 r-xp /usr/lib/libecore_imf.so.1.7.99
40d4a000 40d4b000 rwxp /usr/lib/libecore_imf.so.1.7.99
40d4b000 40d7f000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
40d86000 40d88000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
40d88000 40d8a000 r-xp /usr/lib/libiniparser.so.0
40d92000 40d93000 rwxp /usr/lib/libiniparser.so.0
40d93000 40daa000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
40db1000 40db2000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
40db2000 40db7000 r-xp /usr/lib/libxdgmime.so.1.1.0
40dbe000 40dbf000 rwxp /usr/lib/libxdgmime.so.1.1.0
40dbf000 40dfb000 r-xp /usr/lib/libsystemd.so.0.4.0
40e02000 40e03000 r-xp /usr/lib/libsystemd.so.0.4.0
40e03000 40e04000 rwxp /usr/lib/libsystemd.so.0.4.0
40e04000 40e07000 r-xp /usr/lib/libproc-stat.so.0.2.86
40e0e000 40e0f000 rwxp /usr/lib/libproc-stat.so.0.2.86
40e0f000 40e25000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
40e2c000 40e2d000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
40e2d000 40ea2000 r-xp /usr/lib/libsqlite3.so.0.8.6
40ea9000 40eac000 rwxp /usr/lib/libsqlite3.so.0.8.6
40eac000 40eb2000 r-xp /lib/librt-2.13.so
40eb9000 40eba000 r-xp /lib/librt-2.13.so
40eba000 40ebb000 rwxp /lib/librt-2.13.so
40ebb000 40f8e000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
40f95000 40f99000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
40f99000 40fa0000 r-xp /usr/lib/libsensord-share.so
40fa7000 40fa8000 rwxp /usr/lib/libsensord-share.so
40fa8000 40faf000 r-xp /usr/lib/libXcursor.so.1.0.2
40fb6000 40fb7000 rwxp /usr/lib/libXcursor.so.1.0.2
40fb7000 40fb9000 r-xp /usr/lib/libXdamage.so.1.1.0
40fc0000 40fc1000 rwxp /usr/lib/libXdamage.so.1.1.0
40fc1000 40fc3000 r-xp /usr/lib/libXcomposite.so.1.0.0
40fca000 40fcb000 rwxp /usr/lib/libXcomposite.so.1.0.0
40fcb000 40fcd000 r-xp /usr/lib/libXgesture.so.7.0.0
40fd4000 40fd5000 rwxp /usr/lib/libXgesture.so.7.0.0
40fd5000 40fd8000 r-xp /usr/lib/libXfixes.so.3.1.0
40fdf000 40fe0000 rwxp /usr/lib/libXfixes.so.3.1.0
40fe0000 40fe1000 r-xp /usr/lib/libXinerama.so.1.0.0
40fe9000 40fea000 rwxp /usr/lib/libXinerama.so.1.0.0
40fea000 40ff0000 r-xp /usr/lib/libXrandr.so.2.2.0
40ff7000 40ff8000 rwxp /usr/lib/libXrandr.so.2.2.0
40ff8000 40ffe000 r-xp /usr/lib/libXrender.so.1.3.0
41005000 41006000 rwxp /usr/lib/libXrender.so.1.3.0
41006000 4100a000 r-xp /usr/lib/libXtst.so.6.1.0
41011000 41012000 rwxp /usr/lib/libXtst.so.6.1.0
41012000 4101c000 r-xp /usr/lib/libXext.so.6.4.0
41024000 41025000 rwxp /usr/lib/libXext.so.6.4.0
41025000 4102a000 r-xp /usr/lib/libecore_fb.so.1.7.99
41031000 41033000 rwxp /usr/lib/libecore_fb.so.1.7.99
41033000 41037000 r-xp /usr/lib/libecore_ipc.so.1.7.99
4103f000 41040000 rwxp /usr/lib/libecore_ipc.so.1.7.99
41040000 41043000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
4104a000 4104b000 rwxp /usr/lib/libecore_input_evas.so.1.7.99
4104b000 41061000 r-xp /lib/libexpat.so.1.5.2
41069000 4106b000 rwxp /lib/libexpat.so.1.5.2
4106b000 41081000 r-xp /lib/libz.so.1.2.5
41088000 41089000 rwxp /lib/libz.so.1.2.5
41089000 4109b000 r-xp /usr/lib/libtts.so
410a2000 410a3000 rwxp /usr/lib/libtts.so
410a3000 410c4000 r-xp /usr/lib/libui-extension.so.0.1.0
410cc000 410cd000 rwxp /usr/lib/libui-extension.so.0.1.0
410cd000 410d4000 r-xp /usr/lib/libtbm.so.1.0.0
410db000 410dc000 rwxp /usr/lib/libtbm.so.1.0.0
410dc000 410e3000 r-xp /usr/lib/libembryo.so.1.7.99
410ea000 410eb000 rwxp /usr/lib/libembryo.so.1.7.99
410eb000 41102000 r-xp /usr/lib/liblua-5.1.so
4110a000 4110b000 rwxp /usr/lib/liblua-5.1.so
4110b000 4110c000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
41113000 41114000 rwxp /usr/lib/libecore_imf_evas.so.1.7.99
41115000 41123000 r-xp /usr/lib/libGLESv2.so.2.0
4112b000 4112c000 rwxp /usr/lib/libGLESv2.so.2.0
4112c000 41144000 r-xp /usr/lib/libpng12.so.0.50.0
4114b000 4114c000 rwxp /usr/lib/libpng12.so.0.50.0
4114c000 4114d000 r-xp /usr/lib/libxcb-shm.so.0.0.0
41155000 41156000 rwxp /usr/lib/libxcb-shm.so.0.0.0
41156000 4115c000 r-xp /usr/lib/libxcb-render.so.0.0.0
41163000 41164000 rwxp /usr/lib/libxcb-render.so.0.0.0
41164000 41177000 r-xp /usr/lib/libxcb.so.1.1.0
4117f000 41180000 rwxp /usr/lib/libxcb.so.1.1.0
41180000 41183000 r-xp /usr/lib/libEGL.so.1.4
4118a000 4118b000 rwxp /usr/lib/libEGL.so.1.4
4118c000 411af000 r-xp /usr/lib/libjpeg.so.8.0.2
411b6000 411b7000 rwxp /usr/lib/libjpeg.so.8.0.2
411c7000 4120b000 r-xp /usr/lib/libcurl.so.4.3.0
41212000 41214000 rwxp /usr/lib/libcurl.so.4.3.0
41214000 4121a000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
41222000 41223000 rwxp /usr/lib/libcapi-base-common.so.0.1.8
41223000 41224000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
4122b000 4122c000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
4122d000 41232000 r-xp /usr/lib/libffi.so.5.0.10
41239000 4123a000 rwxp /usr/lib/libffi.so.5.0.10
4123a000 41252000 r-xp /usr/lib/liblzma.so.5.0.3
41259000 4125a000 rwxp /usr/lib/liblzma.so.5.0.3
4125a000 412d6000 r-xp /usr/lib/libgcrypt.so.20.0.3
412dd000 412e2000 rwxp /usr/lib/libgcrypt.so.20.0.3
412e2000 412f2000 r-xp /lib/libresolv-2.13.so
412f2000 412f3000 r-xp /lib/libresolv-2.13.so
412f3000 412f4000 rwxp /lib/libresolv-2.13.so
412f6000 412f8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
41300000 41301000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
41302000 41304000 r-xp /usr/lib/journal/libjournal.so.0.1.0
4130b000 4130c000 rwxp /usr/lib/journal/libjournal.so.0.1.0
4130c000 4130e000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
41315000 41316000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
41316000 4131b000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
41322000 41323000 rwxp /usr/lib/libcapi-system-info.so.0.2.0
41323000 41460000 r-xp /usr/lib/libicui18n.so.51.1
41468000 41470000 rwxp /usr/lib/libicui18n.so.51.1
41471000 41555000 r-xp /usr/lib/libicuuc.so.51.1
4155c000 41566000 rwxp /usr/lib/libicuuc.so.51.1
4156a000 4156d000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
41574000 41575000 rwxp /usr/lib/libcapi-media-image-util.so.0.3.5
41575000 41578000 r-xp /usr/lib/libsmack.so.1.0.0
4157f000 41580000 rwxp /usr/lib/libsmack.so.1.0.0
41580000 41588000 r-xp /usr/lib/libdrm.so.2.4.0
4158f000 41590000 rwxp /usr/lib/libdrm.so.2.4.0
41590000 41592000 r-xp /usr/lib/libXau.so.6.0.0
41599000 4159a000 rwxp /usr/lib/libXau.so.6.0.0
4159b000 415a4000 r-xp /usr/lib/libcares.so.2.1.0
415ac000 415ad000 rwxp /usr/lib/libcares.so.2.1.0
415ad000 415db000 r-xp /usr/lib/libidn.so.11.5.44
415e2000 415e3000 rwxp /usr/lib/libidn.so.11.5.44
415e3000 41630000 r-xp /usr/lib/libssl.so.1.0.0
41637000 4163c000 rwxp /usr/lib/libssl.so.1.0.0
4163c000 417e4000 r-xp /usr/lib/libcrypto.so.1.0.0
417e4000 417f9000 rwxp /usr/lib/libcrypto.so.1.0.0
417fd000 41808000 r-xp /usr/lib/libgpg-error.so.0.15.0
4180f000 41810000 rwxp /usr/lib/libgpg-error.so.0.15.0
41811000 42d90000 r-xp /usr/lib/libicudata.so.51.1
42d97000 42d98000 rwxp /usr/lib/libicudata.so.51.1
42d98000 42d9d000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
42da5000 42da6000 rwxp /usr/lib/libmmutil_jpeg.so.0.0.0
42da6000 42dab000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
42db2000 42db3000 rwxp /usr/lib/libmmutil_imgp.so.0.0.0
42db3000 42db5000 r-xp /usr/lib/libdri2.so.0.0.0
42dbc000 42dbd000 rwxp /usr/lib/libdri2.so.0.0.0
42dbd000 42dde000 r-xp /usr/lib/libexif.so.12.3.3
42de5000 42df1000 rwxp /usr/lib/libexif.so.12.3.3
42df2000 42df7000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
42dfe000 42dff000 rwxp /usr/lib/libcapi-media-tool.so.0.1.5
42f04000 42fce000 r-xp /usr/lib/libCOREGL.so.4.0
42fd6000 42fd8000 rwxp /usr/lib/libCOREGL.so.4.0
42fe0000 43004000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
4300b000 4300d000 rwxp /usr/lib/ecore/immodules/libisf-imf-module.so
4300d000 430dc000 r-xp /usr/lib/libscim-1.0.so.8.2.3
430e3000 430f2000 rwxp /usr/lib/libscim-1.0.so.8.2.3
430f2000 4311f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
43126000 43127000 rwxp /usr/lib/libsecurity-server-client.so.1.0.1
43127000 43144000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
4314c000 4314d000 rwxp /usr/lib/libsecurity-server-commons.so.1.0.0
4314d000 4314f000 r-xp /usr/lib/libiri.so
43156000 43157000 rwxp /usr/lib/libiri.so
43157000 4315a000 r-xp /lib/libcap.so.2.21
43161000 43162000 rwxp /lib/libcap.so.2.21
43162000 43169000 r-xp /lib/libcrypt-2.13.so
43170000 43171000 r-xp /lib/libcrypt-2.13.so
43171000 43172000 rwxp /lib/libcrypt-2.13.so
43199000 4319c000 r-xp /lib/libattr.so.1.1.0
431a3000 431a4000 rwxp /lib/libattr.so.1.1.0
431a4000 431ae000 r-xp /lib/libnss_files-2.13.so
431b5000 431b6000 r-xp /lib/libnss_files-2.13.so
431b6000 431b7000 rwxp /lib/libnss_files-2.13.so
431b7000 433b7000 r-xp /usr/share/locale/locale-archive
433b7000 4342e000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
43436000 43438000 rwxp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
4343e000 4343f000 r-xp /usr/share/locale/en_GB/LC_MESSAGES/libc.mo
4343f000 43587000 r-xp /usr/lib/egl/libMali.so
43587000 4358c000 rwxp /usr/lib/egl/libMali.so
4358d000 43590000 rwxp [stack:3036]
43590000 43594000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
4359b000 4359c000 rwxp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
4359c000 435a0000 rwxs /dev/mali
435a1000 435a4000 r-xp /usr/lib/libnative-buffer.so.0.1.0
435ab000 435ac000 rwxp /usr/lib/libnative-buffer.so.0.1.0
435ad000 43dac000 rwxp [stack:3035]
43dac000 43db4000 rwxs /dev/mali
43db4000 43dbc000 rwxs /dev/mali
43dbc000 43dd0000 r-xs /opt/home/app/.cache/evas_gl_common_caches/ARM::OpenGL
43ed0000 43ed4000 rwxs /dev/mali
43ed4000 43ed8000 rwxs /dev/mali
43ed8000 43ee0000 rwxs /dev/mali
43ee0000 43ee8000 rwxs /dev/mali
43ee8000 43eea000 r-xp /usr/share/locale/en/LC_MESSAGES/elementary.mo
43eea000 44089000 r-xs /usr/share/elementary/themes/tizen-2.3-wearable-circle-HVGA.edj
44189000 441a0000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
441a8000 441ad000 rwxp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
441ad000 441af000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
441b6000 441b7000 rwxp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
441b8000 449b7000 rwxp [stack:3037]
449b7000 449ba000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
449ba000 449be000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
449be000 449cd000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
449cd000 44a58000 r-xp /usr/share/fonts/BreezeSans-MediumCondensed.ttf
44a58000 44a5f000 r-xs /usr/lib/gconv/gconv-modules.cache
44a5f000 44aeb000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
bee8b000 bef82000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3034)
Call Stack Count: 3
 0: _IO_vfprintf + 0x20 (0x40327ee4) [/lib/libc.so.6] + 0x3cee4
 1: _IO_fprintf + 0x1c (0x4033115c) [/lib/libc.so.6] + 0x4615c
 2: save_data + 0xc0 (0x40001b55) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x1b55
End of Call Stack

Package Information
Package Name: org.example.basicui
Package ID : org.example.basicui
Version: 1.0.0
Package Type: rpm
App Name: basicui
App ID: org.example.basicui
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
uestReceived(147) > MessagePort message received
03-26 00:22:07.545+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
03-26 00:22:07.545+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
03-26 00:22:07.545+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:22:07.545+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
03-26 00:22:07.545+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:22:07.550+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:22:07.550+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:22:07.550+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:22:07.550+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
03-26 00:22:07.550+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
03-26 00:22:07.550+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:22:07.550+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
03-26 00:22:07.550+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
03-26 00:22:07.550+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
03-26 00:22:07.550+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:22:07.550+0100 E/CAPI_APPFW_APP_CONTROL(  780): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
03-26 00:22:07.550+0100 W/MUSIC_CONTROL_SERVICE(  780): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:780]   [com.samsung.w-home]register msg port [true][0m
03-26 00:22:07.550+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 14
03-26 00:22:07.555+0100 W/AUL_AMD (  491): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 681
03-26 00:22:07.560+0100 W/MUSIC_CONTROL_SERVICE(  780): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:780]   [MUSIC_PLAYER_EVENT][0m
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
03-26 00:22:07.560+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:22:07.560+0100 W/MUSIC_CONTROL_SERVICE(  780): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:780]   [MUSIC_PLAYER_EVENT][0m
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
03-26 00:22:07.565+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:22:07.565+0100 W/W_HOME  (  681): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
03-26 00:22:07.565+0100 E/W_HOME  (  681): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
03-26 00:22:07.570+0100 W/W_HOME  (  681): clock_shortcut.c: _music_service_messageport_cb(361) > mode:remote state:unknown 
03-26 00:22:07.570+0100 E/W_HOME  (  681): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
03-26 00:22:07.995+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:22:08.855+0100 E/SHealth_Common( 1012): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
03-26 00:22:08.995+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:22:09.105+0100 W/STARTER (  657): hw_key.c: _key_press_cb(1202) > [_key_press_cb:1202] POWER Key is pressed
03-26 00:22:09.105+0100 W/STARTER (  657): hw_key.c: _key_press_cb(1205) > [_key_press_cb:1205] LCD state : 1
03-26 00:22:09.105+0100 W/STARTER (  657): hw_key.c: _key_press_cb(1212) > [_key_press_cb:1212] PM state : 1
03-26 00:22:09.105+0100 W/STARTER (  657): hw_key.c: _key_press_cb(1226) > [_key_press_cb:1226] powerkey count : 1
03-26 00:22:09.230+0100 W/STARTER (  657): hw_key.c: _key_release_cb(1126) > [_key_release_cb:1126] POWER Key is released
03-26 00:22:09.480+0100 W/STARTER (  657): hw_key.c: _powerkey_timer_cb(808) > [_powerkey_timer_cb:808] _powerkey_timer_cb, powerkey count[1]
03-26 00:22:09.480+0100 W/STARTER (  657): hw_key.c: _powerkey_timer_cb(963) > [_powerkey_timer_cb:963] clock visibility[1] pressed lcd status[1], current lcd status[1] pressed pm state[1]
03-26 00:22:09.485+0100 E/STARTER (  657): dbus-util.c: dbus_request_cpu_boost(337) > [dbus_request_cpu_boost:337] failed to _invoke_dbus_method_sync
03-26 00:22:09.490+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 0
03-26 00:22:09.490+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(1702) > caller pid : 657
03-26 00:22:09.495+0100 W/AUL_AMD (  491): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 681
03-26 00:22:09.500+0100 W/AUL_AMD (  491): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(681), cmd(0)
03-26 00:22:09.500+0100 E/AUL     (  657): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
03-26 00:22:09.500+0100 I/APP_CORE(  681): appcore-efl.c: __do_app(429) > [APP 681] Event: RESET State: RUNNING
03-26 00:22:09.500+0100 I/CAPI_APPFW_APPLICATION(  681): app_main.c: app_appcore_reset(245) > app_appcore_reset
03-26 00:22:09.500+0100 W/W_HOME  (  681): main.c: _app_control(1726) > Service value : powerkey
03-26 00:22:09.500+0100 I/wnotib  (  681): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x40001
03-26 00:22:09.500+0100 E/wnotib  (  681): w-notification-board-action-drawer.c: wnotib_action_drawer_popup_shown(4494) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
03-26 00:22:09.500+0100 E/wnotib  (  681): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
03-26 00:22:09.500+0100 W/W_HOME  (  681): noti_broker.c: _noti_broker_home_cb(781) > continue the home key execution
03-26 00:22:09.500+0100 E/W_HOME  (  681): cs_broker.c: _cs_broker_home_cb(256) > (s_info.is_displayed == 0) -> _cs_broker_home_cb() return
03-26 00:22:09.500+0100 W/W_HOME  (  681): move.c: move_move_to_apps(216) > move to apps
03-26 00:22:09.500+0100 W/W_HOME  (  681): rotary.c: rotary_attach(138) > rotary_attach:0x477adae0
03-26 00:22:09.500+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x477adae0, elm_layout, _activated_obj : 0x45b58d58, activated : 1
03-26 00:22:09.500+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
03-26 00:22:09.500+0100 W/W_HOME  (  681): event_manager.c: _move_module_anim_start_cb(635) > state: 0 -> 1
03-26 00:22:09.500+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
03-26 00:22:09.500+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
03-26 00:22:09.500+0100 E/AUL     (  491): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
03-26 00:22:09.510+0100 I/APP_CORE(  681): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
03-26 00:22:09.510+0100 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4474) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
03-26 00:22:09.515+0100 W/W_HOME  (  681): event_manager.c: _apptray_visibility_cb(578) > apps,show,start
03-26 00:22:09.515+0100 W/W_HOME  (  681): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 0
03-26 00:22:09.515+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
03-26 00:22:09.515+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
03-26 00:22:09.515+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
03-26 00:22:09.515+0100 W/W_HOME  (  681): noti_broker.c: _apptray_visibility_cb(788) > apps,show,start
03-26 00:22:09.515+0100 W/W_HOME  (  681): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80002
03-26 00:22:09.515+0100 I/wnotib  (  681): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80002
03-26 00:22:09.515+0100 I/wnotib  (  681): w-notification-board-broker-main.c: _wnotib_view_event_handler(1291) > Unhandled type: 0x80002
03-26 00:22:09.790+0100 W/W_HOME  (  681): event_manager.c: _move_module_anim_end_cb(649) > state: 1 -> 0
03-26 00:22:09.790+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
03-26 00:22:09.790+0100 W/W_HOME  (  681): rotary.c: rotary_deattach(156) > rotary_deattach:0x477adae0
03-26 00:22:09.790+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
03-26 00:22:09.790+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x477adae0, elm_layout, func : 0x4004b359
03-26 00:22:09.790+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
03-26 00:22:09.790+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
03-26 00:22:09.790+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
03-26 00:22:09.790+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45b58d58, elm_box, _activated_obj : 0x477adae0, activated : 1
03-26 00:22:09.790+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
03-26 00:22:09.790+0100 E/wnotib  (  681): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
03-26 00:22:09.790+0100 I/wnotib  (  681): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5387) > Return true for 1, 202.
03-26 00:22:09.790+0100 I/wnotib  (  681): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
03-26 00:22:09.790+0100 W/W_HOME  (  681): event_manager.c: _apptray_visibility_cb(578) > apps,show
03-26 00:22:09.795+0100 W/W_HOME  (  681): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 1
03-26 00:22:09.795+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
03-26 00:22:09.795+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
03-26 00:22:09.795+0100 W/W_HOME  (  681): main.c: home_pause(751) > clock/widget paused
03-26 00:22:09.795+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
03-26 00:22:09.795+0100 W/APPS    (  681): apps_main.c: _time_changed_cb(295) >  date : 26->26
03-26 00:22:09.795+0100 W/W_HOME  (  681): rotary.c: rotary_attach(138) > rotary_attach:0x477b5668
03-26 00:22:09.795+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x477b5668, elm_layout, _activated_obj : 0x45b58d58, activated : 1
03-26 00:22:09.795+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
03-26 00:22:09.795+0100 W/W_HOME  (  681): noti_broker.c: _apptray_visibility_cb(788) > apps,show
03-26 00:22:09.795+0100 W/W_HOME  (  681): noti_broker.c: noti_broker_event_fire_to_plugin(1006) > source:1 event:80000
03-26 00:22:09.795+0100 I/wnotib  (  681): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80000
03-26 00:22:09.795+0100 E/wnotib  (  681): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
03-26 00:22:09.795+0100 I/wnotib  (  681): w-notification-board-panel-basic.c: _wnotib_basic_panel_close_second_depth_view(5438) > wnotib_action_drawer_hidden_get(): 1, page_popup: 0x0
03-26 00:22:09.795+0100 E/wnotib  (  681): w-notification-board-action-drawer.c: wnotib_action_drawer_popup_shown(4494) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
03-26 00:22:09.795+0100 E/wnotib  (  681): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
03-26 00:22:09.795+0100 E/wnotib  (  681): w-notification-board-action-drawer.c: wnotib_action_drawer_is_available(4795) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
03-26 00:22:09.795+0100 I/wnotib  (  681): w-notification-board-noti-manager.c: wnotib_noti_manager_app_tray_changed(1705) > is_app_tray_displayed: 1
03-26 00:22:09.795+0100 E/APPS    (  681): apps_main.c: apps_main_resume(621) >  resumed already
03-26 00:22:09.800+0100 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
03-26 00:22:09.800+0100 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
03-26 00:22:09.800+0100 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
03-26 00:22:09.800+0100 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
03-26 00:22:09.810+0100 W/WATCH_CORE(  702): appcore-watch.c: __widget_pause(1001) > widget_pause
03-26 00:22:10.500+0100 W/AUL_AMD (  491): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
03-26 00:22:10.500+0100 W/AUL_AMD (  491): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
03-26 00:22:11.090+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.090+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 832879
03-26 00:22:11.090+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[0], __focusIndex[4], __pAppsItemList.size[23]
03-26 00:22:11.090+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[5]
03-26 00:22:11.095+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.095+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.095+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.160+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.160+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.160+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.165+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.165+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 832949
03-26 00:22:11.165+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[0], __focusIndex[5], __pAppsItemList.size[23]
03-26 00:22:11.165+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[6]
03-26 00:22:11.175+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:11.225+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.225+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.225+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.240+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.240+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 833016
03-26 00:22:11.240+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[0], __focusIndex[6], __pAppsItemList.size[23]
03-26 00:22:11.240+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[7]
03-26 00:22:11.240+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:11.305+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.305+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.305+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.310+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.310+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 833097
03-26 00:22:11.310+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[0], __focusIndex[7], __pAppsItemList.size[23]
03-26 00:22:11.310+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[1], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[8]
03-26 00:22:11.310+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:11.435+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.435+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.440+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.445+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:11.445+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 833227
03-26 00:22:11.445+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[0], __focusIndex[7], __pAppsItemList.size[23]
03-26 00:22:11.445+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[8]
03-26 00:22:11.450+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:11.470+0100 E/APPS    (  681): AppsViewNecklace.cpp: runEmptyBoxForwardAnimation(3513) >  (!__pEmptyBox) -> runEmptyBoxForwardAnimation() return
03-26 00:22:11.700+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:12.195+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.195+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.195+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.195+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.195+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 833985
03-26 00:22:12.200+0100 W/APPS    (  681): AppsViewNecklace.cpp: onRotary(4702) >  __nTimeStamp:[0], __isFastMoving[0]
03-26 00:22:12.200+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[1], __focusIndex[8], __pAppsItemList.size[23]
03-26 00:22:12.200+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[9]
03-26 00:22:12.260+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.260+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.260+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.260+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.260+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 834050
03-26 00:22:12.260+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[1], __focusIndex[9], __pAppsItemList.size[23]
03-26 00:22:12.260+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[10]
03-26 00:22:12.265+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:12.310+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.315+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.315+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.315+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.315+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 834102
03-26 00:22:12.315+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[1], __focusIndex[10], __pAppsItemList.size[23]
03-26 00:22:12.315+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[11]
03-26 00:22:12.320+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:12.365+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.370+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.370+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.380+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.380+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 834157
03-26 00:22:12.380+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[1], __focusIndex[11], __pAppsItemList.size[23]
03-26 00:22:12.380+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[12]
03-26 00:22:12.380+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:12.420+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.420+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.420+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.425+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.425+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 834210
03-26 00:22:12.425+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[1], __focusIndex[12], __pAppsItemList.size[23]
03-26 00:22:12.425+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[13]
03-26 00:22:12.425+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:12.485+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.485+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.485+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.490+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.490+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 834275
03-26 00:22:12.490+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[1], __focusIndex[13], __pAppsItemList.size[23]
03-26 00:22:12.490+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[14]
03-26 00:22:12.490+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:12.545+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.545+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.545+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.550+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:12.550+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 834337
03-26 00:22:12.550+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[1], __focusIndex[14], __pAppsItemList.size[23]
03-26 00:22:12.550+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[15]
03-26 00:22:12.555+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:12.785+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:13.050+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.050+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.050+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.050+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.050+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 834841
03-26 00:22:13.050+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[1], __focusIndex[15], __pAppsItemList.size[23]
03-26 00:22:13.050+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[1], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[16]
03-26 00:22:13.115+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.115+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.115+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.120+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.120+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 834905
03-26 00:22:13.120+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[1], __focusIndex[15], __pAppsItemList.size[23]
03-26 00:22:13.120+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[16]
03-26 00:22:13.125+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:13.135+0100 E/APPS    (  681): AppsViewNecklace.cpp: runEmptyBoxForwardAnimation(3513) >  (!__pEmptyBox) -> runEmptyBoxForwardAnimation() return
03-26 00:22:13.185+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.185+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.185+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.195+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.195+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 834976
03-26 00:22:13.195+0100 E/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3067) >  (__isPageChanging) -> runRotaryForwardAnimation() return
03-26 00:22:13.250+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.255+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.255+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.260+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:13.260+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 835042
03-26 00:22:13.260+0100 E/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3067) >  (__isPageChanging) -> runRotaryForwardAnimation() return
03-26 00:22:13.360+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:14.250+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:22:14.250+0100 E/EFL     (  681): evas_main<681> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=836042 button=1 downs=1
03-26 00:22:14.250+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [70, 259]
03-26 00:22:14.305+0100 E/EFL     (  681): evas_main<681> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=836096 button=1 downs=0
03-26 00:22:14.305+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [70, 259]->[86, 251]
03-26 00:22:14.305+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[21]
03-26 00:22:14.305+0100 W/APPS    (  681): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,21]
03-26 00:22:14.305+0100 E/APPS    (  681): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-26 00:22:14.305+0100 W/APPS    (  681): AppsItem.cpp: onItemClicked(410) >  item(basicui) launched, open(0)
03-26 00:22:14.315+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 0
03-26 00:22:14.315+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(1702) > caller pid : 681
03-26 00:22:14.315+0100 I/AUL_AMD (  491): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
03-26 00:22:14.325+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(2080) > pad pid(-5)
03-26 00:22:14.325+0100 W/AUL_PAD ( 1131): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
03-26 00:22:14.325+0100 W/AUL_PAD ( 1131): launchpad.c: __send_result_to_caller(272) > Check app launching
03-26 00:22:14.330+0100 E/RESOURCED(  492): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.basicui, table num : 1
03-26 00:22:14.330+0100 E/RESOURCED(  492): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
03-26 00:22:14.365+0100 I/efl-extension( 2966): efl_extension.c: eext_mod_init(40) > Init
03-26 00:22:14.365+0100 I/UXT     ( 2966): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
03-26 00:22:14.370+0100 I/CAPI_APPFW_APPLICATION( 2966): app_main.c: ui_app_main(704) > app_efl_main
03-26 00:22:14.375+0100 I/CAPI_APPFW_APPLICATION( 2966): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
03-26 00:22:14.420+0100 E/TBM     ( 2966): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
03-26 00:22:14.430+0100 E/AUL     (  491): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
03-26 00:22:14.435+0100 E/RESOURCED(  492): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.basicui
03-26 00:22:14.480+0100 E/EFL     ( 2966): ecore_evas<2966> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
03-26 00:22:14.620+0100 W/CRASH_MANAGER( 2954): worker.c: worker_job(1199) > 11029666261731458948134
03-26 00:22:14.890+0100 I/AUL_AMD (  491): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 2966
03-26 00:22:15.445+0100 E/RESOURCED( 1012): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
03-26 00:22:15.445+0100 E/AUL     ( 1012): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
03-26 00:22:15.445+0100 E/CAPI_APPFW_APP_MANAGER( 1012): app_manager.c: app_manager_error(78) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
03-26 00:22:15.680+0100 I/AUL_PAD ( 3031): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
03-26 00:22:16.115+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:22:16.115+0100 E/EFL     (  681): evas_main<681> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=837907 button=1 downs=1
03-26 00:22:16.115+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [89, 264]
03-26 00:22:16.180+0100 E/EFL     (  681): evas_main<681> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=837971 button=1 downs=0
03-26 00:22:16.180+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [89, 264]->[102, 258]
03-26 00:22:16.180+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[21]
03-26 00:22:16.180+0100 W/APPS    (  681): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,21]
03-26 00:22:16.180+0100 E/APPS    (  681): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-26 00:22:16.180+0100 W/APPS    (  681): AppsItem.cpp: onItemClicked(410) >  item(basicui) launched, open(0)
03-26 00:22:16.180+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 0
03-26 00:22:16.185+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(1702) > caller pid : 681
03-26 00:22:16.185+0100 I/AUL_AMD (  491): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
03-26 00:22:16.195+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(2080) > pad pid(-5)
03-26 00:22:16.200+0100 E/RESOURCED(  492): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.basicui, table num : 1
03-26 00:22:16.200+0100 W/AUL_PAD ( 1131): launchpad.c: __launchpad_main_loop(607) > Candidate is not prepared, enter legacy logic
03-26 00:22:16.200+0100 W/AUL_PAD ( 1131): launchpad.c: __send_result_to_caller(272) > Check app launching
03-26 00:22:16.200+0100 E/RESOURCED(  492): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
03-26 00:22:16.200+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(2091) > Launch with legacy way : no launchpad
03-26 00:22:16.200+0100 W/AUL_AMD (  491): amd_launch.c: start_process(580) > child process: 3034
03-26 00:22:16.250+0100 W/AUL_AMD (  491): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 3034
03-26 00:22:16.250+0100 E/AUL     (  491): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
03-26 00:22:16.255+0100 E/RESOURCED(  492): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.basicui
03-26 00:22:16.295+0100 I/efl-extension( 3034): efl_extension.c: eext_mod_init(40) > Init
03-26 00:22:16.320+0100 I/CAPI_APPFW_APPLICATION( 3034): app_main.c: ui_app_main(704) > app_efl_main
03-26 00:22:16.350+0100 I/UXT     ( 3034): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
03-26 00:22:16.360+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 14
03-26 00:22:16.365+0100 W/AUL_AMD (  491): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3034
03-26 00:22:16.365+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 12
03-26 00:22:16.495+0100 I/CAPI_APPFW_APPLICATION( 3034): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
03-26 00:22:16.555+0100 E/TBM     ( 3034): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
03-26 00:22:16.715+0100 E/EFL     ( 3034): ecore_evas<3034> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
03-26 00:22:16.920+0100 W/CRASH_MANAGER( 2954): worker.c: worker_job(1199) > 1103034626173145894813
