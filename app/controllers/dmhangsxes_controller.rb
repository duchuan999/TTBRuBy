class DmhangsxesController < ApplicationController
  helper_method :sort_column, :sort_direction
  respond_to :html, :js

  def index
    @dmhangsxes  = Dmhangsx.search(params[:search]).order(sort_column + " " + sort_direction).paginate(:page => params[:page], :per_page => 12)
    #@dmnuocsxes=Dmnuocsx.all#.paginate(:page => params[:page], :per_page => 12)
  end

  def show
    @dmhangsx = Dmhangsx.find(params[:id])
  end

  def edit
    @dmhangsx = Dmhangsx.find(params[:id])
  end

  def update
    @dmhangsxes = Dmhangsx.search(params[:search]).order(sort_column + " " + sort_direction).paginate(:page => params[:page], :per_page => 12)

    @dmhangsx = Dmhangsx.find(params[:id])
    @dmhangsx.update_attributes(dmhangsx_params)
  end

  def new
    @dmhangsx = Dmhangsx.new
  end

  def create
    @dmhangsxes = Dmhangsx.search(params[:search]).order(sort_column + " " + sort_direction).paginate(:page => params[:page], :per_page => 12)
    @dmhangsx =Dmhangsx.create(dmhangsx_params)
  end

  def delete
    @dmhangsx = Dmhangsx.find(params[:dmhangsx_id])
  end

  def destroy
    @dmhangsxes = Dmhangsx.search(params[:search]).order(sort_column + " " + sort_direction).paginate(:page => params[:page], :per_page => 12)
    @dmhangsx = Dmhangsx.find(params[:id])
    @dmhangsx.destroy
  end

  private
  def dmhangsx_params
    params.require(:dmhangsx).permit(:stt,:ten,:dmnhomhangsx_id)
  end

  def sort_column
    Dmhangsx.column_names.include?(params[:sort]) ? params[:sort] : "ten"
  end
  def sort_direction
    %w[asc desc].include?(params[:direction]) ? params[:direction] : "asc"
  end
end
