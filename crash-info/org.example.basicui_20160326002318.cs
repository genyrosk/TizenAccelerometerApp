S/W Version Information
Model: SM-R720
Tizen-Version: 2.3.1.4
Build-Number: R720XXU2CPB7
Build-Date: 2016.02.24 22:13:42

Crash Information
Process Name: basicui
PID: 3275
Date: 2016-03-26 00:23:18+0100
Executable File Path: /opt/usr/apps/org.example.basicui/bin/basicui
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x6c

Register Information
r0   = 0x42e02400, r1   = 0x40001daa
r2   = 0xbecd3b78, r3   = 0x00000010
r4   = 0xbecd3b80, r5   = 0xbecd3b78
r6   = 0x00000000, r7   = 0xbecd3c1c
r8   = 0xbecd3d3c, r9   = 0x40484c40
r10  = 0x40001daa, fp   = 0xbecd3b64
ip   = 0x40331140, sp   = 0xbecd3600
lr   = 0x40327ee4, pc   = 0x40327ee4
cpsr = 0x60000010

Memory Information
MemTotal:   491012 KB
MemFree:     22652 KB
Buffers:     15284 KB
Cached:     133476 KB
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
PID = 3275 TID = 3275
3275 3276 3277 3279 

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
4358d000 43590000 rwxp [stack:3277]
43590000 43594000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
4359b000 4359c000 rwxp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
4359c000 435a0000 rwxs /dev/mali
435a1000 435a4000 r-xp /usr/lib/libnative-buffer.so.0.1.0
435ab000 435ac000 rwxp /usr/lib/libnative-buffer.so.0.1.0
435ad000 43dac000 rwxp [stack:3276]
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
441b8000 449b7000 rwxp [stack:3279]
449b7000 449ba000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
449ba000 449be000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
449be000 449cd000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
449cd000 44a58000 r-xp /usr/share/fonts/BreezeSans-MediumCondensed.ttf
44a58000 44a5f000 r-xs /usr/lib/gconv/gconv-modules.cache
44a5f000 44aeb000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
becc8000 bedbf000 rwxp [stack]
End of Maps Information

Callstack Information (PID:3275)
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
6.165+0100 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
03-26 00:23:06.165+0100 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
03-26 00:23:06.190+0100 W/WATCH_CORE(  702): appcore-watch.c: __signal_process_manager_handler(1163) > process_manager_signal
03-26 00:23:06.190+0100 I/WATCH_CORE(  702): appcore-watch.c: __signal_process_manager_handler(1179) > Call the time_tick_cb
03-26 00:23:06.190+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:23:06.200+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 22
03-26 00:23:06.200+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(890) > app status : 4
03-26 00:23:06.205+0100 I/efl-extension( 3203): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x44ad6390, elm_scroller, _activated_obj : 0x44ad6390, activated : 0
03-26 00:23:06.215+0100 I/MALI    (  681): egl_platform_x11_tizen.c: tizen_update_native_surface_private(176) > [EGL-X11] surface->[0x442d1618] swap changed from async to sync
03-26 00:23:06.225+0100 I/efl-extension( 3203): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x44ad6390, obj: 0x44ad6390
03-26 00:23:06.225+0100 I/efl-extension( 3203): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
03-26 00:23:06.225+0100 I/efl-extension( 3203): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
03-26 00:23:06.225+0100 I/efl-extension( 3203): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
03-26 00:23:06.225+0100 I/efl-extension( 3203): efl_extension_rotary.c: _object_deleted_cb(601) > done
03-26 00:23:06.240+0100 I/efl-extension( 3203): efl_extension_circle_surface.c: _eext_circle_surface_del_cb(680) > Surface is going to free in delete callback for image widget.
03-26 00:23:06.240+0100 I/efl-extension( 3203): efl_extension_circle_surface.c: _eext_circle_surface_del_internal(993) > surface 0x44d42558 is freed
03-26 00:23:06.240+0100 I/efl-extension( 3203): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
03-26 00:23:06.240+0100 I/efl-extension( 3203): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44ad6390, elm_scroller, func : 0x411bcef1
03-26 00:23:06.240+0100 I/efl-extension( 3203): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
03-26 00:23:06.240+0100 I/efl-extension( 3203): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
03-26 00:23:06.240+0100 I/efl-extension( 3203): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x44d4f170, elm_image, func : 0x411bcef1
03-26 00:23:06.240+0100 I/efl-extension( 3203): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
03-26 00:23:06.240+0100 I/efl-extension( 3203): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(833) > [0x44ad6390 : elm_scroller] rotary callabck is deleted
03-26 00:23:06.255+0100 I/MALI    ( 3203): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
03-26 00:23:06.255+0100 I/MALI    ( 3203): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=3203   close drm_fd=27 
03-26 00:23:06.255+0100 I/MALI    ( 3203): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
03-26 00:23:06.270+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 22
03-26 00:23:06.270+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(890) > app status : 4
03-26 00:23:06.270+0100 E/APP_CORE( 3203): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
03-26 00:23:06.270+0100 I/APP_CORE( 3203): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
03-26 00:23:06.270+0100 I/APP_CORE( 3203): appcore-efl.c: __after_loop(1090) > [APP 3203] PAUSE before termination
03-26 00:23:06.270+0100 I/CAPI_APPFW_APPLICATION( 3203): app_main.c: app_appcore_pause(202) > app_appcore_pause
03-26 00:23:06.270+0100 I/WC_POPUP( 3203): main.c: app_pause(261) > 
03-26 00:23:06.270+0100 I/CAPI_APPFW_APPLICATION( 3203): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
03-26 00:23:06.270+0100 I/WC_POPUP( 3203): main.c: app_terminate(172) > 
03-26 00:23:06.275+0100 W/WC_POPUP( 3203): bt-connection-handler.c: _bt_deinit(288) > bt_deinitialize already done
03-26 00:23:06.330+0100 I/UXT     ( 3203): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
03-26 00:23:06.475+0100 E/APP_CORE( 3161): appcore.c: __del_vconf(429) > [FAILED]vconfkey_ignore_key_changed
03-26 00:23:06.475+0100 I/APP_CORE( 3161): appcore-efl.c: __after_loop(1088) > Legacy lifecycle: 0
03-26 00:23:06.475+0100 I/CAPI_APPFW_APPLICATION( 3161): app_main.c: app_appcore_terminate(177) > app_appcore_terminate
03-26 00:23:06.475+0100 W/WFMD    ( 3161): wfmd-main.c: app_terminate(1255) > 
03-26 00:23:06.475+0100 E/WFMD    ( 3161): wfmd-main.c: _wfmd_network_status_callback_set(701) > vconf_ignore_key_changed error : [-1]
03-26 00:23:06.475+0100 E/WFMD    ( 3161): wfmd-main.c: _wfmd_network_status_callback_set(707) > vconf_ignore_key_changed error : [-1]
03-26 00:23:06.490+0100 I/AUL_PAD ( 3201): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
03-26 00:23:06.620+0100 I/efl-extension( 3203): efl_extension.c: eext_mod_shutdown(46) > Shutdown
03-26 00:23:06.770+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 23
03-26 00:23:06.770+0100 W/AUL_AMD (  491): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
03-26 00:23:06.770+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 3203
03-26 00:23:06.770+0100 W/AUL_AMD (  491): amd_request.c: __send_app_termination_signal(511) > send dead signal done
03-26 00:23:06.775+0100 I/AUL_AMD (  491): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3203
03-26 00:23:06.785+0100 I/efl-extension( 3161): efl_extension_rotary.c: _object_deleted_cb(572) > In: data: 0x441fd208, obj: 0x441fd208
03-26 00:23:06.785+0100 I/efl-extension( 3161): efl_extension_rotary.c: _remove_ecore_handlers(554) > In
03-26 00:23:06.785+0100 I/efl-extension( 3161): efl_extension_rotary.c: _remove_ecore_handlers(559) > removed _motion_handler
03-26 00:23:06.785+0100 I/efl-extension( 3161): efl_extension_rotary.c: _remove_ecore_handlers(565) > removed _rotate_handler
03-26 00:23:06.785+0100 I/efl-extension( 3161): efl_extension_rotary.c: _object_deleted_cb(601) > done
03-26 00:23:06.785+0100 I/efl-extension( 3161): efl_extension_rotary.c: _activated_obj_del_cb(607) > _activated_obj_del_cb : 0x442a98e8
03-26 00:23:06.785+0100 I/efl-extension( 3161): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
03-26 00:23:06.785+0100 I/efl-extension( 3161): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x441fd208, elm_scroller, func : 0x419a0ef1
03-26 00:23:06.785+0100 I/efl-extension( 3161): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
03-26 00:23:06.785+0100 I/efl-extension( 3161): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
03-26 00:23:06.785+0100 I/efl-extension( 3161): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x442a98e8, elm_image, func : 0x419a0ef1
03-26 00:23:06.785+0100 I/efl-extension( 3161): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
03-26 00:23:06.785+0100 I/efl-extension( 3161): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_del_cb(833) > [0x441fd208 : elm_scroller] rotary callabck is deleted
03-26 00:23:06.855+0100 I/MALI    ( 3161): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
03-26 00:23:06.855+0100 I/MALI    ( 3161): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=3161   close drm_fd=25 
03-26 00:23:06.855+0100 I/MALI    ( 3161): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
03-26 00:23:06.965+0100 I/UXT     ( 3161): Uxt_ObjectManager.cpp: OnTerminating(750) > Terminating.
03-26 00:23:07.230+0100 I/efl-extension( 3161): efl_extension.c: eext_mod_shutdown(46) > Shutdown
03-26 00:23:07.285+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:23:07.285+0100 E/EFL     (  681): evas_main<681> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=889076 button=1 downs=1
03-26 00:23:07.285+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [255, 83]
03-26 00:23:07.405+0100 I/AUL_AMD (  491): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3161
03-26 00:23:07.470+0100 E/EFL     (  681): evas_main<681> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=889261 button=1 downs=0
03-26 00:23:07.470+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [255, 83]->[238, 73]
03-26 00:23:07.470+0100 E/APPS    (  681): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-26 00:23:07.470+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[15]
03-26 00:23:07.510+0100 E/APPS    (  681): AppsViewNecklace.cpp: runEmptyBoxBackwardAnimation(3604) >  (!__pEmptyBox) -> runEmptyBoxBackwardAnimation() return
03-26 00:23:07.740+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:23:08.115+0100 I/efl-extension( 3202): efl_extension.c: eext_mod_init(40) > Init
03-26 00:23:08.200+0100 W/AUL_AMD (  491): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
03-26 00:23:08.270+0100 W/AUL_AMD (  491): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
03-26 00:23:08.330+0100 I/UXT     ( 3202): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
03-26 00:23:08.345+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:23:08.345+0100 E/EFL     (  681): evas_main<681> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=890137 button=1 downs=1
03-26 00:23:08.350+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [113, 79]
03-26 00:23:08.445+0100 E/EFL     (  681): evas_main<681> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=890235 button=1 downs=0
03-26 00:23:08.445+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [113, 79]->[118, 81]
03-26 00:23:08.445+0100 E/APPS    (  681): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-26 00:23:08.445+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[16]
03-26 00:23:08.455+0100 E/APPS    (  681): AppsViewNecklace.cpp: runEmptyBoxForwardAnimation(3513) >  (!__pEmptyBox) -> runEmptyBoxForwardAnimation() return
03-26 00:23:08.690+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:23:08.995+0100 E/SHealth_Common( 1012): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
03-26 00:23:09.115+0100 E/AUL_PAD ( 1131): launchpad.c: main(854) > Refused candidate process connection
03-26 00:23:09.130+0100 I/efl-extension( 3168): efl_extension.c: eext_mod_shutdown(46) > Shutdown
03-26 00:23:09.230+0100 I/MALI    ( 3168): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
03-26 00:23:09.230+0100 I/MALI    ( 3168): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=3168   close drm_fd=22 
03-26 00:23:09.230+0100 I/MALI    ( 3168): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
03-26 00:23:09.260+0100 I/AUL_PAD ( 3202): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
03-26 00:23:09.400+0100 I/AUL_AMD (  491): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3168
03-26 00:23:09.490+0100 E/TBM     ( 3202): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
03-26 00:23:09.495+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:09.495+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 891286
03-26 00:23:09.495+0100 W/APPS    (  681): AppsViewNecklace.cpp: onRotary(4702) >  __nTimeStamp:[0], __isFastMoving[0]
03-26 00:23:09.495+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[2], __focusIndex[16], __pAppsItemList.size[23]
03-26 00:23:09.495+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[17]
03-26 00:23:09.495+0100 I/efl-extension( 3124): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:09.495+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:09.580+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:09.580+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:09.580+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 891369
03-26 00:23:09.580+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[2], __focusIndex[17], __pAppsItemList.size[23]
03-26 00:23:09.580+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[18]
03-26 00:23:09.585+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:23:09.595+0100 I/efl-extension( 3124): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:09.780+0100 I/efl-extension( 3124): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:09.780+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:09.780+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 891569
03-26 00:23:09.780+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[2], __focusIndex[18], __pAppsItemList.size[23]
03-26 00:23:09.780+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[19]
03-26 00:23:09.780+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:23:09.785+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:09.950+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:09.950+0100 I/efl-extension( 3124): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:09.955+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:09.955+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 891735
03-26 00:23:09.955+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[2], __focusIndex[19], __pAppsItemList.size[23]
03-26 00:23:09.955+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[20]
03-26 00:23:09.960+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:23:10.185+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:23:10.445+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:10.445+0100 I/efl-extension( 3124): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:10.445+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 892236
03-26 00:23:10.445+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[2], __focusIndex[20], __pAppsItemList.size[23]
03-26 00:23:10.445+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[21]
03-26 00:23:10.445+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:10.680+0100 I/efl-extension( 3124): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:10.680+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:10.685+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(444) > direction: Clockwise
03-26 00:23:10.685+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(526) > Deliver clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 892472
03-26 00:23:10.685+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryForwardAnimation(3069) >  __nIsEditMode[0], __focusPage[2], __focusIndex[21], __pAppsItemList.size[23]
03-26 00:23:10.685+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[22]
03-26 00:23:10.685+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:23:10.915+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:23:11.260+0100 I/efl-extension(  681): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:23:11.260+0100 I/efl-extension(  681): efl_extension_rotary.c: _rotary_rotate_handler_cb(528) > Deliver counter clockwise rotary event to object: 0x477b5668, elm_layout, time_stamp : 893052
03-26 00:23:11.260+0100 W/APPS    (  681): AppsViewNecklace.cpp: runRotaryBackwardAnimation(3169) >  __nIsEditMode[0], __focusPage[2], __focusIndex[22], __pAppsItemList.size[23]
03-26 00:23:11.260+0100 W/APPS    (  681): AppsViewNecklace.cpp: runFocusAni(2987) >  __isFocusNext[0], __isFocusPrev[0], __isFocusRecent[0], nNewFocus[21]
03-26 00:23:11.265+0100 I/efl-extension( 1133): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:23:11.275+0100 I/efl-extension( 3124): efl_extension_rotary.c: _process_raw_event(438) > direction: Counter Clockwise
03-26 00:23:11.495+0100 W/APPS    (  681): AppsViewNecklace.cpp: onAutoLaunchTimerStart(4378) >  auto launch is disabled
03-26 00:23:11.960+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:23:11.960+0100 E/EFL     (  681): evas_main<681> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=893752 button=1 downs=1
03-26 00:23:11.965+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [167, 174]
03-26 00:23:12.020+0100 E/EFL     (  681): evas_main<681> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=893805 button=1 downs=0
03-26 00:23:12.020+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [167, 174]->[167, 176]
03-26 00:23:12.025+0100 W/APPS    (  681): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,21]
03-26 00:23:12.025+0100 E/APPS    (  681): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-26 00:23:12.025+0100 W/APPS    (  681): AppsItem.cpp: onItemClicked(410) >  item(basicui) launched, open(0)
03-26 00:23:12.030+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 0
03-26 00:23:12.030+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(1702) > caller pid : 681
03-26 00:23:12.030+0100 I/AUL_AMD (  491): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
03-26 00:23:12.040+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(2080) > pad pid(-5)
03-26 00:23:12.040+0100 W/AUL_PAD ( 1131): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
03-26 00:23:12.040+0100 W/AUL_PAD ( 1131): launchpad.c: __send_result_to_caller(272) > Check app launching
03-26 00:23:12.040+0100 E/RESOURCED(  492): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.basicui, table num : 1
03-26 00:23:12.040+0100 E/RESOURCED(  492): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
03-26 00:23:12.075+0100 I/efl-extension( 3201): efl_extension.c: eext_mod_init(40) > Init
03-26 00:23:12.075+0100 I/UXT     ( 3201): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
03-26 00:23:12.080+0100 I/CAPI_APPFW_APPLICATION( 3201): app_main.c: ui_app_main(704) > app_efl_main
03-26 00:23:12.085+0100 I/CAPI_APPFW_APPLICATION( 3201): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
03-26 00:23:12.145+0100 E/TBM     ( 3201): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
03-26 00:23:12.145+0100 E/AUL     (  491): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
03-26 00:23:12.150+0100 E/RESOURCED(  492): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.basicui
03-26 00:23:12.250+0100 E/EFL     ( 3201): ecore_evas<3201> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
03-26 00:23:12.520+0100 W/CRASH_MANAGER( 2954): worker.c: worker_job(1199) > 11032016261731458948192
03-26 00:23:12.910+0100 I/AUL_AMD (  491): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3201
03-26 00:23:13.150+0100 E/RESOURCED( 1012): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
03-26 00:23:13.150+0100 E/AUL     ( 1012): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
03-26 00:23:13.150+0100 E/CAPI_APPFW_APP_MANAGER( 1012): app_manager.c: app_manager_error(78) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
03-26 00:23:13.315+0100 E/AUL_PAD ( 1131): launchpad.c: main(854) > Refused candidate process connection
03-26 00:23:13.320+0100 I/efl-extension( 3202): efl_extension.c: eext_mod_shutdown(46) > Shutdown
03-26 00:23:13.385+0100 I/MALI    ( 3202): egl_platform_x11.c: __egl_platform_terminate(302) > [EGL-X11] ################################################
03-26 00:23:13.385+0100 I/MALI    ( 3202): egl_platform_x11.c: __egl_platform_terminate(303) > [EGL-X11] PID=3202   close drm_fd=21 
03-26 00:23:13.385+0100 I/MALI    ( 3202): egl_platform_x11.c: __egl_platform_terminate(304) > [EGL-X11] ################################################
03-26 00:23:13.485+0100 I/AUL_AMD (  491): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3202
03-26 00:23:13.820+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:23:13.820+0100 E/EFL     (  681): evas_main<681> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=895610 button=1 downs=1
03-26 00:23:13.820+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [171, 207]
03-26 00:23:13.915+0100 E/EFL     (  681): evas_main<681> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=895697 button=1 downs=0
03-26 00:23:13.915+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [171, 207]->[175, 205]
03-26 00:23:13.915+0100 W/APPS    (  681): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,21]
03-26 00:23:13.920+0100 E/APPS    (  681): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-26 00:23:13.920+0100 W/APPS    (  681): AppsItem.cpp: onItemClicked(410) >  item(basicui) launched, open(0)
03-26 00:23:13.925+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 0
03-26 00:23:13.925+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(1702) > caller pid : 681
03-26 00:23:13.925+0100 I/AUL_AMD (  491): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
03-26 00:23:13.935+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(2080) > pad pid(-5)
03-26 00:23:13.935+0100 W/AUL_PAD ( 1131): launchpad.c: __launchpad_main_loop(607) > Candidate is not prepared, enter legacy logic
03-26 00:23:13.935+0100 W/AUL_PAD ( 1131): launchpad.c: __send_result_to_caller(272) > Check app launching
03-26 00:23:13.935+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(2091) > Launch with legacy way : no launchpad
03-26 00:23:13.935+0100 W/AUL_AMD (  491): amd_launch.c: start_process(580) > child process: 3261
03-26 00:23:13.935+0100 E/RESOURCED(  492): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.basicui, table num : 1
03-26 00:23:13.940+0100 E/RESOURCED(  492): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
03-26 00:23:13.985+0100 W/AUL_AMD (  491): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 3261
03-26 00:23:13.990+0100 E/AUL     (  491): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
03-26 00:23:13.990+0100 E/RESOURCED(  492): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.basicui
03-26 00:23:14.035+0100 I/efl-extension( 3261): efl_extension.c: eext_mod_init(40) > Init
03-26 00:23:14.065+0100 I/CAPI_APPFW_APPLICATION( 3261): app_main.c: ui_app_main(704) > app_efl_main
03-26 00:23:14.115+0100 I/UXT     ( 3261): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
03-26 00:23:14.330+0100 I/CAPI_APPFW_APPLICATION( 3261): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
03-26 00:23:14.385+0100 E/TBM     ( 3261): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
03-26 00:23:14.390+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 14
03-26 00:23:14.395+0100 W/AUL_AMD (  491): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3261
03-26 00:23:14.400+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 12
03-26 00:23:14.535+0100 E/EFL     ( 3261): ecore_evas<3261> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
03-26 00:23:14.725+0100 I/AUL_PAD ( 3253): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
03-26 00:23:15.070+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 23
03-26 00:23:15.070+0100 W/AUL_AMD (  491): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
03-26 00:23:15.070+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 3261
03-26 00:23:15.070+0100 W/AUL_AMD (  491): amd_request.c: __send_app_termination_signal(511) > send dead signal done
03-26 00:23:15.075+0100 I/AUL_AMD (  491): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3261
03-26 00:23:15.510+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:23:15.515+0100 E/EFL     (  681): evas_main<681> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=897301 button=1 downs=1
03-26 00:23:15.515+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [178, 192]
03-26 00:23:15.625+0100 E/EFL     (  681): evas_main<681> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=897410 button=1 downs=0
03-26 00:23:15.625+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [178, 192]->[155, 189]
03-26 00:23:15.630+0100 W/APPS    (  681): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,21]
03-26 00:23:15.630+0100 E/APPS    (  681): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-26 00:23:15.630+0100 W/APPS    (  681): AppsItem.cpp: onItemClicked(410) >  item(basicui) launched, open(0)
03-26 00:23:15.635+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 0
03-26 00:23:15.635+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(1702) > caller pid : 681
03-26 00:23:15.635+0100 I/AUL_AMD (  491): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
03-26 00:23:15.645+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(2080) > pad pid(-5)
03-26 00:23:15.645+0100 W/AUL_PAD ( 1131): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
03-26 00:23:15.650+0100 W/AUL_PAD ( 1131): launchpad.c: __send_result_to_caller(272) > Check app launching
03-26 00:23:15.655+0100 E/RESOURCED(  492): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.basicui, table num : 1
03-26 00:23:15.655+0100 E/RESOURCED(  492): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
03-26 00:23:15.695+0100 I/efl-extension( 3253): efl_extension.c: eext_mod_init(40) > Init
03-26 00:23:15.695+0100 I/UXT     ( 3253): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
03-26 00:23:15.700+0100 I/CAPI_APPFW_APPLICATION( 3253): app_main.c: ui_app_main(704) > app_efl_main
03-26 00:23:15.705+0100 I/CAPI_APPFW_APPLICATION( 3253): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
03-26 00:23:15.750+0100 E/AUL     (  491): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
03-26 00:23:15.750+0100 E/RESOURCED(  492): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.basicui
03-26 00:23:15.750+0100 E/TBM     ( 3253): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
03-26 00:23:15.810+0100 E/EFL     ( 3253): ecore_evas<3253> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
03-26 00:23:16.115+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:23:16.390+0100 I/AUL_AMD (  491): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3253
03-26 00:23:16.720+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:23:16.770+0100 E/RESOURCED( 1012): proc-stat.c: send_socket_with_repy(767) > [send_socket_with_repy,767] send_socket_with_repy: read failed
03-26 00:23:16.770+0100 E/AUL     ( 1012): pkginfo.c: __get_id_bypid(197) > Failed to get the cmdline of pid, error: -1
03-26 00:23:16.770+0100 E/CAPI_APPFW_APP_MANAGER( 1012): app_manager.c: app_manager_error(78) > [app_context_get_app_context_by_pid] No such application(0xfeef0001)
03-26 00:23:17.330+0100 I/GESTURE (  138): gesture.c: GestureRecognize(2948) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
03-26 00:23:17.330+0100 E/EFL     (  681): evas_main<681> evas_events.c:994 evas_event_feed_mouse_down() ButtonEvent:down time=899119 button=1 downs=1
03-26 00:23:17.330+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchPressed(1227) >  TOUCH [157, 188]
03-26 00:23:17.415+0100 E/EFL     (  681): evas_main<681> evas_events.c:1258 evas_event_feed_mouse_up() ButtonEvent:up time=899195 button=1 downs=0
03-26 00:23:17.415+0100 W/APPS    (  681): AppsViewNecklace.cpp: touchReleased(1546) >  TOUCH [157, 188]->[149, 184]
03-26 00:23:17.415+0100 W/APPS    (  681): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,21]
03-26 00:23:17.415+0100 E/APPS    (  681): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
03-26 00:23:17.415+0100 W/APPS    (  681): AppsItem.cpp: onItemClicked(410) >  item(basicui) launched, open(0)
03-26 00:23:17.415+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 0
03-26 00:23:17.415+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(1702) > caller pid : 681
03-26 00:23:17.415+0100 I/AUL_AMD (  491): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
03-26 00:23:17.430+0100 E/RESOURCED(  492): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.basicui, table num : 1
03-26 00:23:17.430+0100 E/RESOURCED(  492): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
03-26 00:23:17.430+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(2080) > pad pid(-5)
03-26 00:23:17.435+0100 W/AUL_PAD ( 1131): launchpad.c: __launchpad_main_loop(607) > Candidate is not prepared, enter legacy logic
03-26 00:23:17.435+0100 W/AUL_PAD ( 1131): launchpad.c: __send_result_to_caller(272) > Check app launching
03-26 00:23:17.435+0100 W/AUL_AMD (  491): amd_launch.c: _start_app(2091) > Launch with legacy way : no launchpad
03-26 00:23:17.435+0100 W/AUL_AMD (  491): amd_launch.c: start_process(580) > child process: 3275
03-26 00:23:17.485+0100 W/AUL_AMD (  491): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 3275
03-26 00:23:17.485+0100 E/AUL     (  491): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
03-26 00:23:17.490+0100 E/RESOURCED(  492): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : org.example.basicui
03-26 00:23:17.580+0100 I/efl-extension( 3275): efl_extension.c: eext_mod_init(40) > Init
03-26 00:23:17.625+0100 I/CAPI_APPFW_APPLICATION( 3275): app_main.c: ui_app_main(704) > app_efl_main
03-26 00:23:17.695+0100 I/UXT     ( 3275): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
03-26 00:23:17.775+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 14
03-26 00:23:17.785+0100 W/AUL_AMD (  491): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3275
03-26 00:23:17.785+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 12
03-26 00:23:17.890+0100 I/CAPI_APPFW_APPLICATION( 3275): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
03-26 00:23:17.960+0100 E/TBM     ( 3275): tbm_bufmgr.c: _tbm_bufmgr_init_state(674) > USE TGL LOCK!
03-26 00:23:18.135+0100 E/EFL     ( 3275): ecore_evas<3275> ecore_evas_extn.c:2202 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
03-26 00:23:18.150+0100 W/WATCH_CORE(  702): appcore-watch.c: __signal_context_handler(1192) > _signal_context_handler: type: 0, state: 3
03-26 00:23:18.150+0100 I/WATCH_CORE(  702): appcore-watch.c: __signal_context_handler(1209) > Call the time_tick_cb
03-26 00:23:18.150+0100 I/CAPI_WATCH_APPLICATION(  702): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
03-26 00:23:18.170+0100 W/WATCH_CORE(  702): appcore-watch.c: __signal_lcd_status_handler(1130) > signal_lcd_status_signal: LCDOff
03-26 00:23:18.170+0100 W/WAKEUP-SERVICE( 1058): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : 1075153676[0;m
03-26 00:23:18.170+0100 W/WAKEUP-SERVICE( 1058): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
03-26 00:23:18.170+0100 W/WAKEUP-SERVICE( 1058): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
03-26 00:23:18.175+0100 W/W_HOME  (  681): dbus.c: _dbus_message_recv_cb(204) > LCD off
03-26 00:23:18.175+0100 W/W_HOME  (  681): gesture.c: _manual_render_disable_timer_del(151) > timer del
03-26 00:23:18.175+0100 W/W_HOME  (  681): gesture.c: _manual_render_enable(133) > 1
03-26 00:23:18.175+0100 W/W_HOME  (  681): event_manager.c: _lcd_off_cb(699) > lcd state: 0
03-26 00:23:18.175+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
03-26 00:23:18.175+0100 W/STARTER (  657): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [gesture]
03-26 00:23:18.175+0100 W/STARTER (  657): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
03-26 00:23:18.175+0100 E/STARTER (  657): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
03-26 00:23:18.175+0100 W/STARTER (  657): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
03-26 00:23:18.175+0100 W/STARTER (  657): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
03-26 00:23:18.180+0100 I/TIZEN_N_SOUND_MANAGER( 1058): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1216) > [SVOICE] Wake up Disable start
03-26 00:23:18.235+0100 I/TIZEN_N_SOUND_MANAGER( 1058): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1219) > [SVOICE] Wake up Disable end. (ret: 0x0)
03-26 00:23:18.235+0100 W/TIZEN_N_SOUND_MANAGER( 1058): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
03-26 00:23:18.235+0100 W/WAKEUP-SERVICE( 1058): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
03-26 00:23:18.235+0100 I/HIGEAR  ( 1058): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
03-26 00:23:18.315+0100 W/MUSIC_CONTROL_SERVICE(  780): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:780]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
03-26 00:23:18.315+0100 W/STARTER (  657): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [gesture]
03-26 00:23:18.315+0100 W/STARTER (  657): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
03-26 00:23:18.315+0100 W/STARTER (  657): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
03-26 00:23:18.315+0100 W/STARTER (  657): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[0]
03-26 00:23:18.325+0100 I/APP_CORE(  681): appcore-efl.c: __do_app(429) > [APP 681] Event: PAUSE State: RUNNING
03-26 00:23:18.325+0100 I/CAPI_APPFW_APPLICATION(  681): app_main.c: app_appcore_pause(202) > app_appcore_pause
03-26 00:23:18.325+0100 W/W_HOME  (  681): main.c: _appcore_pause_cb(690) > appcore pause
03-26 00:23:18.325+0100 W/W_HOME  (  681): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
03-26 00:23:18.325+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
03-26 00:23:18.325+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
03-26 00:23:18.325+0100 W/W_HOME  (  681): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:0 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
03-26 00:23:18.325+0100 W/W_HOME  (  681): rotary.c: rotary_deattach(156) > rotary_deattach:0x477b5668
03-26 00:23:18.325+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
03-26 00:23:18.325+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0x477b5668, elm_layout, func : 0x4004b359
03-26 00:23:18.325+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
03-26 00:23:18.325+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
03-26 00:23:18.325+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
03-26 00:23:18.325+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0x45b58d58, elm_box, _activated_obj : 0x477b5668, activated : 1
03-26 00:23:18.325+0100 I/efl-extension(  681): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
03-26 00:23:18.325+0100 E/wnotib  (  681): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
03-26 00:23:18.325+0100 I/wnotib  (  681): w-notification-board-panel-basic.c: _wnotib_basic_panel_passed_key_event_allow(5387) > Return true for 1, 202.
03-26 00:23:18.325+0100 I/wnotib  (  681): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
03-26 00:23:18.330+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:23:18.330+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:23:18.330+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:23:18.330+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
03-26 00:23:18.330+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
03-26 00:23:18.330+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:23:18.330+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
03-26 00:23:18.330+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:23:18.340+0100 E/ALARM_MANAGER(  657): alarm-lib.c: alarmmgr_add_alarm_withcb(1162) > trigger_at_time(20), start(26-3-2016, 00:23:38), repeat(1), interval(20), type(-1073741822)
03-26 00:23:18.345+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
03-26 00:23:18.345+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
03-26 00:23:18.345+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
03-26 00:23:18.345+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
03-26 00:23:18.345+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
03-26 00:23:18.345+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
03-26 00:23:18.345+0100 I/MESSAGE_PORT(  455): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
03-26 00:23:18.345+0100 I/MESSAGE_PORT(  455): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
03-26 00:23:18.345+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
03-26 00:23:18.345+0100 I/MESSAGE_PORT(  455): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
03-26 00:23:18.345+0100 E/CAPI_APPFW_APP_CONTROL(  780): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
03-26 00:23:18.345+0100 W/MUSIC_CONTROL_SERVICE(  780): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:780]   [com.samsung.w-home]register msg port [false][0m
03-26 00:23:18.345+0100 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4501) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
03-26 00:23:18.345+0100 W/GESTURE (  138): gesture.c: BackGestureSetProperty(4506) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
03-26 00:23:18.350+0100 W/ALARM_MANAGER(  489): alarm-manager.c: __check_privilege_by_cookie(1525) > Try to read procfs status
03-26 00:23:18.350+0100 W/ALARM_MANAGER(  489): alarm-manager.c: __check_privilege_by_cookie(1529) > Read procfs status successfully
03-26 00:23:18.400+0100 I/SHealth_Common( 1012): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
03-26 00:23:18.400+0100 I/SHealth_Service( 1012): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
03-26 00:23:18.440+0100 E/ALARM_MANAGER(  489): alarm-manager-schedule.c: _alarm_next_duetime(504) > alarm_id: 1861371125, next duetime: 1458948218
03-26 00:23:18.440+0100 E/ALARM_MANAGER(  489): alarm-manager.c: __alarm_add_to_list(377) > [alarm-server]: After add alarm_id(1861371125)
03-26 00:23:18.440+0100 E/ALARM_MANAGER(  489): alarm-manager.c: __alarm_create(938) > [alarm-server]:alarm_context.c_due_time(1458981420), due_time(1458948218)
03-26 00:23:18.440+0100 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(229) > [alarm-server]ALARM_CLEAR ioctl is successfully done.
03-26 00:23:18.440+0100 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(236) > Setted RTC Alarm date/time is 25-3-2016, 23:23:38 (UTC).
03-26 00:23:18.440+0100 E/ALARM_MANAGER(  489): alarm-manager.c: __rtc_set(251) > [alarm-server]RTC ALARM_SET ioctl is successfully done.
03-26 00:23:18.615+0100 W/APPS    (  681): AppsViewNecklace.cpp: onPausedIdlerCb(4522) >  elm_cache_all_flush
03-26 00:23:18.715+0100 I/AUL_PAD ( 3274): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
03-26 00:23:18.845+0100 I/APP_CORE(  681): appcore-efl.c: __do_app(429) > [APP 681] Event: MEM_FLUSH State: PAUSED
03-26 00:23:18.905+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(646) > __request_handler: 23
03-26 00:23:18.905+0100 W/AUL_AMD (  491): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 0
03-26 00:23:18.905+0100 W/AUL_AMD (  491): amd_request.c: __request_handler(923) > pkg_status: installed, dead pid: 3275
03-26 00:23:18.905+0100 W/AUL_AMD (  491): amd_request.c: __send_app_termination_signal(511) > send dead signal done
03-26 00:23:18.905+0100 I/AUL_AMD (  491): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3275
03-26 00:23:21.200+0100 W/CRASH_MANAGER( 2954): worker.c: worker_job(1199) > 11032616261731458948194
03-26 00:23:23.350+0100 I/APP_CORE(  681): appcore-efl.c: __do_app(429) > [APP 681] Event: MEM_FLUSH State: PAUSED
03-26 00:23:29.255+0100 W/CRASH_MANAGER( 2954): worker.c: worker_job(1199) > 11032536261731458948195
03-26 00:23:29.785+0100 W/CRASH_MANAGER( 2954): worker.c: worker_job(1199) > 1103275626173145894819
