from sklearn.tree import DecisionTreeClassifier
from sklearn import datasets
from IPython.display import Image
from sklearn import tree
import os #only for windows
import pydotplus
#for windows only
os.environ['PATH'] += os.pathsep+ "C:/graphviz-2.38/release/bin/"

iris=datasets.load_iris()
x=iris.data
y=iris.target

clf=DecisionTreeClassifier(random_state=0)

model=clf.fit(x,y)

dot_data=tree.export_graphviz(clf,out_file=None,feature_names=iris.feature_names,class_names=iris.target_names)

graph =pydotplus.graph_from_dot_data(dot_data)

Image(graph.create_png())

graph.write_pdf("krunal_prac52.pdf")

graph.write_png("krunal_prac52.png")
