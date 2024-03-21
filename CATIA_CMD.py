
import win32com
import sys
from icecream import ic
from win32com.client import Dispatch, constants
catia = win32com.client.Dispatch("CATIA.Application")

def run_command():
    # 定义一个指令-消息映射字典
    message_dict = {
        "ln": "Line",
        "cir": "Circle",
        "pt": "Point",
        "inc":"Insert New Content",
        "new":"New Content",
        "cl":"Close Surface",
        "lvl":"Levels",
        "ramp":"Ramp",
        "sph":"Sphere",
        "grid":"Grid label",
        "reo":"Reoder",
        "cham":"Chamfer",
        "int":"Intersect...",
        "unfold":"Unfold",
        "txt":"Text with Leader",
        "stair":"stairwell",
        "sca":"Scaling",
        "geo":"Geometrical Set...",
        "rep":"Replace...",
        "body":"Body",
        "pc":"PowerCopy Creation...",
        "geo":"Geometry",
        "rot":"Rotate",
        "spl":"Spline",
        "int":"Intersection",
        "sym":"Symmetry",
        "act":"Action",
        "sync":"Synchronize All",
        "vol":"Volume Extrude",
        "ext":"Extract",
        "mext":"Multiple Extract",
        "mulso":"Nulti-section Solid",
        "proj":"Projection",
        "spl":"Split",
        "iso":"Isoparametric Curve",
        "mea":"Measure",
        "trim":"Trim",
        "extr":"Extremum",
        "for":"Formula",
        "rem":"Remove",
        "rule":"Rule",
        "vb":"Visual Basic Action",
        "langu":"Language Browser",
        "rec":"Reaction",
        "vsd":"Visual Script Designer",
        "kr":"Knowledge Report",
        "kp":"Knowledge Pattern",
        "uti":"Utility",
        "va":"View Angle",
        "hole":"Hole",
        "vba":"Macros...",
        "rib":"Rib",
        "slab":"slab",
        "Text":"Text",
        "comb":"Combine",
        "sked":"sketch from DWG",
        "dt":"Design Table",
        "law":"Law",
        "mulvol":"Multi-Sections Volume",
        "bod":"Boundary",
        "faca":"Variable Curtain Wall",
        "bd":"Body",
        "mulsr":"Multi-Sections Surface",
        "tra":"Translate",
        "cor":"Corner",
        "wall":"Wall",
        "swp":"sweep",
        "poc":"Pocket",
        "add":"Add...",
        "off":"Offset",
        "poly":"Polyline",
        "ext":"Extrude",
        "trans":"Transform",
        "check":"Check",
        "pln":"Plane",
        "plb":"Plane Between",
        "axis":"Axis System",
        "corc":"Connect Curve",
        "conic":"Conic",
        "3cv":"3D Curve",
        "helix":"Helix",
        "spi":"Spiral",
        "par":"Parallel Curve",
        "roo":"Rolling Offset",
        "3co":"3D Curve Offset",
        "fill":"Fill",
        "ble":"Blend",
        "jo":"Join",
        "hea":"Healing",
        "cs":"Curve Smooth",
        "unt":"Untrim",
        "dis":"Disassemble",
        "cp":"Create Polyline",
        "trs":"Translate",
        "rot":"Rotate",
        "sym":"Symmetry",
        "sca":"Scaling",
        "aff":"Affinity",
        "2axis":"Axis To Axis",
        "extr":"Extrapolate",
        "inv":"Invert Orientation",
        "near":"Near / Far",
        "shf":"Shape Fillet",
        "edf":"Edge Fillet"

    }

    message_dict_zh = {
         "ln": "线"
    }
    while True:
        # 输入指令
        user_input = input("Please enter the command:")

        # 判断是否要退出循环
        if user_input.lower() == 'exit':
            break
            sys.exit()

        # 使用get方法获取对应的消息，如果没有对应的指令，则返回默认值
        message = message_dict.get(user_input, "Unknown command, please re-enter.")

        # 打印消息
        print(message)
        catia.StartCommand(message) 


if __name__ == "__main__":
    run_command()
