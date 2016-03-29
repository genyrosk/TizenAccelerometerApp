S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.4
Build-Number: R720XXU2CPB7
Build-Date: 2016.02.24 22:13:42

Crash Information
Process Name: basicui
PID: 3127
Date: 2016-03-26 00:22:45+0100
Executable File Path: /opt/usr/apps/org.example.basicui/bin/basicui
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x6c

Register Information
r0   = 0x42e02400, r1   = 0x40001daa
r2   = 0xbed6db78, r3   = 0x00000010
r4   = 0xbed6db80, r5   = 0xbed6db78
r6   = 0x00000000, r7   = 0xbed6dc1c
r8   = 0xbed6dd3c, r9   = 0x40484c40
r10  = 0x40001daa, fp   = 0xbed6db64
ip   = 0x40331140, sp   = 0xbed6d600
lr   = 0x40327ee4, pc   = 0x40327ee4
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     12368 KB
Buffers:     16076 KB
Cached:     167924 KB
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
VmPTE:          52 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 3127 TID = 3127
3127 3129 3130 3131 

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
4358d000 43590000 rwxp [stack:3130]
43590000 43594000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
4359b000 4359c000 rwxp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
4359c000 435a0000 rwxs /dev/mali
435a1000 435a4000 r-xp /usr/lib/libnative-buffer.so.0.1.0
435ab000 435ac000 rwxp /usr/lib/libnative-buffer.so.0.1.0
435ad000 43dac000 rwxp [stack:3129]
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
441b8000 449b7000 rwxp [stack:3131]
449b7000 449ba000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
449ba000 449be000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
449be000 449cd000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
449cd000 44a58000 r-xp /usr/share/fonts/BreezeSans-MediumCondensed.ttf
44a58000 44a5f000 r-xs /usr/lib/gconv/gconv-modules.cache
44a5f000 44aeb000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
bed62000 bee59000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3127)
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
1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:25.835+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.835+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.835+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 847626
03-26 00:22:25.835+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:25.835+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.835+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.870+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.870+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.870+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 847661
03-26 00:22:25.870+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:25.870+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.870+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.900+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.900+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.900+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 847690
03-26 00:22:25.900+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:25.900+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.900+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.940+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.940+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.940+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 847730
03-26 00:22:25.940+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:25.940+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.940+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.975+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.975+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.975+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 847767
03-26 00:22:25.975+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:25.975+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:25.975+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.030+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.030+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.030+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 847819
03-26 00:22:26.030+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:26.030+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.030+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.095+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.095+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.095+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 847884
03-26 00:22:26.095+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:26.095+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.095+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.180+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.180+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.180+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 847972
03-26 00:22:26.180+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:26.180+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.180+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.405+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.405+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.405+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 848194
03-26 00:22:26.405+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:26.405+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.405+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.465+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.465+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.465+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 848257
03-26 00:22:26.465+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:26.465+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.465+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.510+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.510+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.510+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 848304
03-26 00:22:26.510+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:26.515+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.515+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.560+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.560+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.560+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 848349
03-26 00:22:26.560+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:26.560+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.560+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.600+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.600+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.600+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 848393
03-26 00:22:26.600+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:26.600+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.600+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.650+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.650+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.650+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 848443
03-26 00:22:26.650+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:26.650+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.650+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:26.805+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.805+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.805+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 848594
03-26 00:22:26.805+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:26.805+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.805+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.840+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.840+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.840+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 848630
03-26 00:22:26.840+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:26.840+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.840+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.875+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.875+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.875+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 848668
03-26 00:22:26.875+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:26.880+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.880+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.920+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.920+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.920+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 848709
03-26 00:22:26.920+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:26.920+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.920+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.970+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.970+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.970+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 848762
03-26 00:22:26.970+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:26.970+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:26.970+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:36.400+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:22:36.400+0100 E/EFL     (  681): evas_main<681> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=858191 button=1 downs=1
03-26 00:22:36.400+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [154, 121]
03-26 00:22:36.835+0100 E/EFL     (  681): evas_main<681> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=858618 button=1 downs=0
03-26 00:22:36.835+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [154, 121]->[189, 284]
03-26 00:22:37.220+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:22:37.225+0100 E/EFL     (  681): evas_main<681> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=859014 button=1 downs=1
03-26 00:22:37.225+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [220, 83]
03-26 00:22:37.330+0100 E/EFL     (  681): evas_main<681> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=859123 button=1 downs=0
03-26 00:22:37.330+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [220, 83]->[220, 84]
03-26 00:22:37.330+0100 E/APPS    (  681): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-26 00:22:37.330+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[15]
03-26 00:22:37.350+0100 E/APPS    (  681): AppsViewNecklace.cpp: runEmptyBoxBackwardAnimation(3604) >  (!__pEmptyBox) -> runEmptyBoxBackwardAnimation() return
03-26 00:22:37.570+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:38.355+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.355+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.355+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.355+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.355+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 860145
03-26 00:22:38.355+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:38.440+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.440+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.440+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 860232
03-26 00:22:38.440+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:38.440+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.440+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.445+0100 I/RESOURCED(  492): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
03-26 00:22:38.445+0100 I/RESOURCED(  492): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
03-26 00:22:38.525+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.525+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.525+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 860318
03-26 00:22:38.525+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:38.530+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.530+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.640+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.640+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.640+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 860430
03-26 00:22:38.640+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:38.640+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:38.640+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:39.140+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:22:39.140+0100 E/EFL     (  681): evas_main<681> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=860930 button=1 downs=1
03-26 00:22:39.140+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [113, 75]
03-26 00:22:39.225+0100 E/EFL     (  681): evas_main<681> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=861017 button=1 downs=0
03-26 00:22:39.225+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [113, 75]->[119, 77]
03-26 00:22:39.225+0100 E/APPS    (  681): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-26 00:22:39.225+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[16]
03-26 00:22:39.235+0100 E/APPS    (  681): AppsViewNecklace.cpp: runEmptyBoxForwardAnimation(3513) >  (!__pEmptyBox) -> runEmptyBoxForwardAnimation() return
03-26 00:22:39.465+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:22:40.170+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:40.170+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 861961
03-26 00:22:40.170+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:40.170+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:40.170+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:40.170+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:40.260+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:40.260+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 862049
03-26 00:22:40.260+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:40.260+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:40.260+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:40.260+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:40.445+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:40.445+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 862238
03-26 00:22:40.445+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:40.450+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:40.450+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:40.450+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:40.705+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:40.705+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 862496
03-26 00:22:40.705+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:40.705+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:40.705+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:40.705+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:40.815+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:40.815+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:40.815+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 862607
03-26 00:22:40.815+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:40.815+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:40.815+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:40.910+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:40.910+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 862702
03-26 00:22:40.910+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:40.910+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:40.910+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:40.910+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:41.065+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:41.065+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:41.065+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 862857
03-26 00:22:41.065+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:41.065+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:41.065+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:41.180+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:41.180+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:41.180+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 862972
03-26 00:22:41.180+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:41.180+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:41.180+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:41.550+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.555+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.555+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 863344
03-26 00:22:41.555+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:41.555+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.555+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.585+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.585+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.585+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 863378
03-26 00:22:41.585+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:41.585+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.585+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.625+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.625+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.625+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 863417
03-26 00:22:41.625+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:41.625+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.625+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.675+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.675+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.675+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 863464
03-26 00:22:41.675+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:41.675+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.675+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.745+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.745+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.745+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 863537
03-26 00:22:41.745+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:41.745+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.745+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.825+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.825+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.825+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 863618
03-26 00:22:41.825+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:41.830+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.830+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:41.965+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:41.965+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:41.965+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 863755
03-26 00:22:41.965+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:41.965+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:41.965+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.020+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.025+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.025+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 863814
03-26 00:22:42.025+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:42.025+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.025+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.080+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.080+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.080+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 863869
03-26 00:22:42.080+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:42.080+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.080+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.115+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.115+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.115+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 863908
03-26 00:22:42.115+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:42.115+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.115+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.165+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.165+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.165+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 863957
03-26 00:22:42.165+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:42.165+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.165+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:22:42.315+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.315+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.315+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 864106
03-26 00:22:42.315+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:42.315+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.315+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.335+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.335+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.335+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 864127
03-26 00:22:42.335+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:42.335+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.335+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.365+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.365+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.365+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 864157
03-26 00:22:42.365+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:42.365+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.365+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.455+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.455+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.455+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 864245
03-26 00:22:42.455+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:42.455+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.455+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.515+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.515+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.515+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 864307
03-26 00:22:42.515+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:42.515+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.515+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.625+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.625+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.625+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 864415
03-26 00:22:42.625+0100 E/APPS    (  681): AppsViewNecklace.cpp: onRotary(4689) >  App is moving[0,0,1]
03-26 00:22:42.625+0100 I/efl-extension( 1207): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:42.625+0100 I/efl-extension( 1748): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:22:43.470+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:22:43.470+0100 E/EFL     (  681): evas_main<681> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=865261 button=1 downs=1
03-26 00:22:43.470+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [88, 266]
03-26 00:22:43.495+0100 E/EFL     (  681): evas_main<681> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=865283 button=1 downs=0
03-26 00:22:43.495+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [88, 266]->[109, 258]
03-26 00:22:43.495+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[21]
03-26 00:22:43.495+0100 W/APPS    (  681): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,21]
03-26 00:22:43.495+0100 E/APPS    (  681): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-26 00:22:43.495+0100 W/APPS    (  681): AppsItem.cpp: onItemClicked(410) >  item(basicui) launched, open(0)
03-26 00:22:43.495+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 0
03-26 00:22:43.495+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(1702) > caller pid : 681
03-26 00:22:43.495+0100 I/AUL_AMD (  491): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
03-26 00:22:43.510+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(2080) > pad pid(-5)
03-26 00:22:43.510+0100 E/RESOURCED(  492): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.basicui, table num : 1
03-26 00:22:43.510+0100 E/RESOURCED(  492): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
03-26 00:22:43.510+0100 W/AUL_PAD ( 1131): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
03-26 00:22:43.510+0100 W/AUL_PAD ( 1131): launchpad.c: __send_result_to_caller(272) > Check app launching
03-26 00:22:43.545+0100 I/efl-extension( 3031): efl_extension.c: eext_mod_init(40) > Init
03-26 00:22:43.545+0100 I/UXT     ( 3031): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
03-26 00:22:43.550+0100 I/CAPI_APPFW_APPLICATION( 3031): app_main.c: ui_app_main(704) > app_efl_main
03-26 00:22:43.550+0100 I/CAPI_APPFW_APPLICATION( 3031): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
03-26 00:22:43.595+0100 E/TBM     ( 3031): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
03-26 00:22:43.615+0100 E/AUL     (  491): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
03-26 00:22:43.615+0100 E/RESOURCED(  492): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.basicui
03-26 00:22:43.650+0100 E/EFL     ( 3031): ecore_evas<3031> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
03-26 00:22:43.800+0100 W/CRASH_MANAGER( 2954): worker.c: worker_job(1199) > 11030316261731458948163
03-26 00:22:44.040+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:22:44.170+0100 I/AUL_AMD (  491): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3031
03-26 00:22:44.650+0100 E/RESOURCED( 1012): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
03-26 00:22:44.650+0100 E/AUL     ( 1012): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
03-26 00:22:44.650+0100 E/CAPI_APPFW_APP_MANAGER( 1012): app_manager.c: app_manager_error(78) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
03-26 00:22:44.710+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:22:44.715+0100 E/EFL     (  681): evas_main<681> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=866504 button=1 downs=1
03-26 00:22:44.715+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [82, 253]
03-26 00:22:44.780+0100 E/EFL     (  681): evas_main<681> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=866570 button=1 downs=0
03-26 00:22:44.780+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [82, 253]->[94, 249]
03-26 00:22:44.780+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[21]
03-26 00:22:44.780+0100 W/APPS    (  681): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,21]
03-26 00:22:44.780+0100 E/APPS    (  681): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-26 00:22:44.780+0100 W/APPS    (  681): AppsItem.cpp: onItemClicked(410) >  item(basicui) launched, open(0)
03-26 00:22:44.785+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 0
03-26 00:22:44.785+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(1702) > caller pid : 681
03-26 00:22:44.785+0100 I/AUL_AMD (  491): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
03-26 00:22:44.795+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(2080) > pad pid(-5)
03-26 00:22:44.795+0100 W/AUL_PAD ( 1131): launchpad.c: __launchpad_main_loop(607) > Candidate is not prepared, enter legacy logic
03-26 00:22:44.795+0100 W/AUL_PAD ( 1131): launchpad.c: __send_result_to_caller(272) > Check app launching
03-26 00:22:44.795+0100 E/RESOURCED(  492): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.basicui, table num : 1
03-26 00:22:44.795+0100 E/RESOURCED(  492): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
03-26 00:22:44.795+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(2091) > Launch with legacy way : no launchpad
03-26 00:22:44.795+0100 W/AUL_AMD (  491): amd_launch.c: start_process(580) > child process: 3127
03-26 00:22:44.850+0100 W/AUL_AMD (  491): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 3127
03-26 00:22:44.850+0100 E/AUL     (  491): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
03-26 00:22:44.850+0100 E/RESOURCED(  492): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.basicui
03-26 00:22:44.910+0100 I/efl-extension( 3127): efl_extension.c: eext_mod_init(40) > Init
03-26 00:22:44.925+0100 I/CAPI_APPFW_APPLICATION( 3127): app_main.c: ui_app_main(704) > app_efl_main
03-26 00:22:44.965+0100 I/UXT     ( 3127): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
03-26 00:22:45.105+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 14
03-26 00:22:45.110+0100 W/AUL_AMD (  491): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3127
03-26 00:22:45.150+0100 I/CAPI_APPFW_APPLICATION( 3127): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
03-26 00:22:45.175+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 12
03-26 00:22:45.205+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:22:45.215+0100 E/TBM     ( 3127): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
03-26 00:22:45.460+0100 E/EFL     ( 3127): ecore_evas<3127> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
03-26 00:22:45.665+0100 W/CRASH_MANAGER( 2954): worker.c: worker_job(1199) > 1103127626173145894816
