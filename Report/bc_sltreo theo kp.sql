---so luong treo---
select b.makp,d.ten tenkp,c.ten||' '||c.hamluong tenbd ,sum(a.soluong) from medibv115.d_treo a,medibv1150610.d_xuatsdll b,d_dmbd c,d_duockp d 
where a.id=b.id and a.mabd=c.id and b.makhoa=d.id group by b.makp,d.ten,c.ten||' '||c.hamluong
---so luong linh ---
select b.makp,d.ten tenkp,c.ten||' '||c.hamluong tenbd ,sum(a.soluong) from medibv1150610.D_THUCBUCSTT a,medibv1150610.d_xuatsdll b,d_dmbd c,d_duockp d 
where a.id=b.id and a.mabd=c.id and b.makhoa=d.id group by b.makp,d.ten,c.ten||' '||c.hamluong

